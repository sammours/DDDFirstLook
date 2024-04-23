using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DDDFirstLook.Domain.Primitives
{
    public class FirstName
    {
        private readonly string value;

        public FirstName(string value)
        {
            if (!IsValid(value))
            {
                throw new Exception($"First name {value} not valid");
            }

            this.value = value;
        }

        public static bool IsValid(string value)
        {
            if (value == null)
            {
                return false;
            }

            if (!Regex.IsMatch(value, @"^[\w]+$"))
            {
                return false;
            }

            return true;
        }

        public static bool TryParse(string value, out FirstName postalCode)
        {
            postalCode = null;
            if (string.IsNullOrWhiteSpace(value))
                return false;

            postalCode = new FirstName(value.Trim().ToUpper());
            return true;
        }

        public static implicit operator string(FirstName postalCode)
        {
            return postalCode.value;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }

        public override bool Equals(object obj)
        {
            var other = obj as FirstName;
            if (other == null)
                return base.Equals(obj);

            return object.Equals(this.value, other.value);
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
    }
}
