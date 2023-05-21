using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiStariqChlenNaFamiliqta
{
    internal class Family
    {
        private List<Person> members;

        public List<Person> Members
        {
            get { return members; }
            set { members = value; }
        }
        public Family()
        {
            this.Members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }
        public Person GetSortedMembers()
        {
            return this.Members.OrderByDescending(x => x.Age).First();
        }
    }
}
