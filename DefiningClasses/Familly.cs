using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Familly
    {
        private List<Person> people;

        public Familly()
        {
            this.people = new List<Person>();
        }

        public Person Person { get; set; }
        
        public void AddMember(Person member)
        {
            this.people.Add(member);
        }

        public Person GetOldestMember()
        {
            var olderMember = people
                .OrderByDescending(x => x.Age)
                .FirstOrDefault();

            return olderMember;
        }

        public List<Person> GetAll30PlusMembers()
        {
            List<Person> all30PlusMembers = people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();

            return all30PlusMembers;
        }
    }
}
