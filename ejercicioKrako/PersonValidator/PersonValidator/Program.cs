using PersonRepository;
using PersonRepository.Interfaces;

namespace PersonValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var va = new ValidatorTest();
            va.Validate(new DonnaClase());
            
        }
    }
}
