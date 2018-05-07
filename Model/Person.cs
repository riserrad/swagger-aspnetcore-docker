using System.ComponentModel.DataAnnotations;

namespace swagger_training.Model
{
    public class Person{
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        private string _heroName;

        public string HeroName {get{ return _heroName; }}

        public void SetHeroName(){
            _heroName = HeroGenerator.GetHeroName(this.FirstName, this.LastName);
        }

    }
}