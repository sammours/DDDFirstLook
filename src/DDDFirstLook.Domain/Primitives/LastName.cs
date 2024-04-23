using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DDDFirstLook.Domain.Primitives
{
    public class LastName
    {
        private readonly string value;

        private LastName(string value)
        {
            this.value = value;
        }

        public static LastName Create(string postalCode)
        {
            if (!IsValid(postalCode))
            {
                throw new Exception($"Postal Code {postalCode} not valid");
            }

            return new LastName(postalCode);
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

        public static bool TryParse(string value, out LastName postalCode)
        {
            postalCode = null;
            if (string.IsNullOrWhiteSpace(value))
                return false;

            postalCode = Create(value.Trim().ToUpper());
            return true;
        }

        public static implicit operator string(LastName postalCode)
        {
            return postalCode.value;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }

        public override bool Equals(object obj)
        {
            var other = obj as LastName;
            if (other == null)
                return base.Equals(obj);

            return object.Equals(this.value, other.value);
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
    }

    public static class LastNameFactory
    {
        public static LastName Create(string value)
        {
            return LastName.Create(value);
        }
    }
}
