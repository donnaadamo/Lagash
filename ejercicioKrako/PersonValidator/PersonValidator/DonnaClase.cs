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
            throw new NotImplementedException();
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
            List<Person> nC = new List<Person>();
            nC = People.FindAll(p => );
            return notCapitalized;
        }

        public Dictionary<int, string[]> GroupEmailByNameCount()
        {
            throw new NotImplementedException();
        }
    }
}