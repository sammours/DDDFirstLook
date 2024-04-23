using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DDDFirstLook.Domain.Primitives
{
    public class PostalCode
    {
        private readonly string value;

        private PostalCode(string value)
        {
            this.value = value;
        }

        public static PostalCode Create(string postalCode)
        {
            if (!IsValid(postalCode))
            {
                throw new Exception($"Postal Code {postalCode} not valid");
            }

            return new PostalCode(postalCode);
        }

        public static bool IsValid(string value)
        {
            if (value == null)
            {
                return false;
            }

            if (!Regex.IsMatch(value, @"^[\d]{5}$"))
            {
                return false;
            }

            return true;
        }

        public static bool TryParse(string value, out PostalCode postalCode)
        {
            postalCode = null;
            if (string.IsNullOrWhiteSpace(value))
                return false;

            postalCode = Create(value.Trim().ToUpper());
            return true;
        }

        public static implicit operator string(PostalCode postalCode)
        {
            return postalCode.value;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }

        public override bool Equals(object obj)
        {
            var other = obj as PostalCode;
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
