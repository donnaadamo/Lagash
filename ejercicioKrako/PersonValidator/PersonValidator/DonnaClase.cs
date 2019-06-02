using PersonRepository.Entities;
using PersonRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PersonValidator{
class DonnaClase : IPersonRepositoryAdvanced
{
    public List<Person> People { get; set; }

    bool validateId(int id){
        return People.Exists(p => p.Id == id);
    }

    bool validateAge(int age){
        return age>0;
    }

    bool validateEmail(string email){
        return email.Contains(".") && email.Contains("@");
    }

    /*bool validatePerson(int id, int age, string email){
        return validateEmail(email) && validateAge(age) && !validateId(id);
    }*/
    public void Add(Person person)
        {   
            /*
            if (validatePerson(person.Id, person.Age, person.Email)){
                People.Add(person);
            }*/
            
            if (!validateId(person.Id) && validateAge(person.Age) && validateEmail(person.Email)){
                People.Add(person);
            }
        }

    public void Delete(int id)
        {
            People.Remove(GetPerson(id));
        }

    public int GetCountRangeAges(int min, int max)
        {
            /*var range = 0;
            foreach (Person p in People){
                if (p.Age >= min && p.Age <= max){
                    range++;
                }
            }
            return range;*/
            return People.FindAll(p => p.Age >= min && p.Age <= max).Count;
        }

    public List<Person> GetFiltered(string name, int age, string email)
        {
            List<Person> Filtered = People;

            if (name != null && name != ""){
                Filtered = Filtered.FindAll(p => p.Name == name);
            }

            if (age != 0){
                Filtered = Filtered.FindAll(p => p.Age == age);
            }

            if (email != null && email != ""){
                Filtered = Filtered.FindAll(p => p.Email.Contains(email));
            }

            return Filtered;
        }

    public Person GetPerson(int Id)
        {
           return People.Find(p => p.Id == Id);
        }

    public void Update(Person person)
        {
            if (validateId(person.Id)){
                Delete(person.Id);
                Add(person);
            }
        }

        public int[] GetNotCapitalizedIds()
        {
            List<string> names = new List<string>();
            List<string> notCapitalized = new List<string>();
            List<Person> notCapitalizedPerson = new List<Person>();
            List<int> notCapitalizedId = new List<int>();

            foreach (Person p in People){
                names.Add(p.Name);
            }

            var namesSplit = names.ToArray();
            for (int i=0; i<namesSplit.Length; i++){
                string[] names2 = namesSplit[i].Split(' ');
                for (int j=0; j<names2.Length; j++){
                    if (char.IsLower(names2[j][0])){
                        notCapitalized.Add(namesSplit[i]);
                    }
                }
            }
            
            notCapitalizedPerson = People.FindAll(p => notCapitalized.Contains(p.Name));
            foreach (Person p in notCapitalizedPerson){
                notCapitalizedId.Add(p.Id);
            }
            return notCapitalizedId.ToArray();
        }

        public Dictionary<int, string[]> GroupEmailByNameCount()
        {
            throw new NotImplementedException();
        }
    }
}