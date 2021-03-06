using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Newtonsoft.Json;

namespace Example.Console.Models
{
    public class Person
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDayDateTime { get; set; }
        public Collection<PhoneNumber> PhoneNumbers { get; set; }
        public Dictionary<string, string> AllThings { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}. Phone numbers: {2}", FirstName, LastName,
                PhoneNumbers.Any() ? string.Join(",", PhoneNumbers.Select(p => p.Number)) : "-");
        }
    }

    public class PhoneNumber
    {
        public string Number { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Type, Number);
        }
    }
}