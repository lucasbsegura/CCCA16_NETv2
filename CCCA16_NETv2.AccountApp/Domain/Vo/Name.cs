using System.Text.RegularExpressions;

namespace CCCA16_NETv2.AccountApp.Domain.Vo
{
    public class Name
    {
        private string Value { get; set; }

        public Name(string name)
        {
            if (Regex.IsMatch(name, "/[a-zA-Z] [a-zA-Z]+/")) throw new Exception("Invalid name");
            this.Value = name;
        }

        public string GetValue()
        {
            return this.Value;
        }
    }
}
