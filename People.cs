using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Samost0504
{
    class People : IEnumerable<Person>, ISortable
    {
        private List<Person> people = new List<Person>();

        public override string ToString()
        {
            string peopleStr = "";
            for (var i = 0; i < people.Count; i++)
                peopleStr += people[i].ToString() + "\n";
            return peopleStr;
        }

        public void Sort()
        {
            people.Sort();
        }

        public void LoadData(StreamReader input)
        {
            string s = "";
            while(!input.EndOfStream)
            {
                s = input.ReadLine();
                string[] parts = s.Split(' ');
                people.Add(new Person { Name = parts[0], Age = int.Parse(parts[1]) });
            }
        }

        public IEnumerator<Person> GetEnumerator()
        {
            for (var i = 0; i < people.Count; i++)
                yield return people[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
