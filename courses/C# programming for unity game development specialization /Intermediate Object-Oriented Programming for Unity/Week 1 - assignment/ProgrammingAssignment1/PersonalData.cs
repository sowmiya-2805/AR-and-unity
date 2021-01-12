using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// A class holding personal data for a person
    /// </summary>
    public class PersonalData
    {
        #region Fields

        // declare your fields here
        const string fileName = "ValidData.txt";

        static string firstName = "";
        static string middleName = "";
        static string lastName = "";
        static string streetAddress = "";
        static string city = "";
        static string state = "";
        static string postalCode = "";
        static string country = "";
        static string phoneNumber = "";

        #endregion

        #region Properties

        /// <summary>
        /// Gets the person's first name
        /// </summary>
        public string FirstName
        {
            get 
            {
                // delete code below and replace with correct code
                return firstName;
            }
        }

        /// <summary>
        /// Gets the person's middle name
        /// </summary>
        public string MiddleName
        {
            get
            {
                // delete code below and replace with correct code
                return middleName;
            }
        }

        /// <summary>
        /// Gets the person's last name
        /// </summary>
        public string LastName
        {
            get
            {
                // delete code below and replace with correct code
                return lastName;
            }
        }

        /// <summary>
        /// Gets the person's street address
        /// </summary>
        public string StreetAddress
        {
            get
            {
                // delete code below and replace with correct code
                return streetAddress;
            }
        }

        /// <summary>
        /// Gets the person's city or town
        /// </summary>
        public string City
        {
            get
            {
                // delete code below and replace with correct code
                return city;
            }
        }

        /// <summary>
        /// Gets the person's state or province
        /// </summary>
        public string State
        {
            get
            {
                // delete code below and replace with correct code
                return state;
            }
        }

        /// <summary>
        /// Gets the person's postal code
        /// </summary>
        public string PostalCode
        {
            get
            {
                // delete code below and replace with correct code
                return postalCode;
            }
        }

        /// <summary>
        /// Gets the person's country
        /// </summary>
        public string Country
        {
            get
            {
                // delete code below and replace with correct code
                return country;
            }
        }

        /// <summary>
        /// Gets the person's phone number (digits only, no 
        /// parentheses, spaces, or dashes)
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                // delete code below and replace with correct code
                return phoneNumber;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// Reads personal data from a file. If the file
        /// read fails, the object contains an empty string for all
        /// the personal data
        /// </summary>
        /// <param name="fileName">name of file holding personal data</param>
        public PersonalData(string fileName)
        {
            // your code can assume we know the order in which the
            // values appear in the string; it's the same order as
            // they're listed for the properties above. We could do 
            // something more complicated with the names and values, 
            // but that's not necessary here

            StreamReader input = null;
            try
            {
                input = File.OpenText(fileName);

                string values = input.ReadLine();
                SetConfigurationDataFields(values);
            }

            catch (Exception e)
            {
            }

            finally
            {
                if(input != null)
                {
                    input.Close();
                }
            }

            // IMPORTANT: The mono compiler the automated grader uses
            // does NOT support the string Split method. You have to 
            // use the IndexOf method to find comma locations and the
            // Substring method to chop off the front of the string
            // after you extract each value to extract and save the
            // personal data
        }

        static void SetConfigurationDataFields(string csvValues)
        {

            String[] values = Split(csvValues, new char[] { ',' });

            firstName = values[0];
            middleName = values[1];
            lastName = values[2];
            streetAddress = values[3];
            city = values[4];
            state = values[5];
            postalCode = values[6];
            country = values[7];
            phoneNumber = values[8];
        }

        public static String[] Split(String txt, char[] delim)
        {
            if (txt == null)
                return new String[0]; // or exception
            if (delim == null || delim.Length == 0)
                return new String[0]; // or exception

            char[] text = txt.ToCharArray();
            string[] result = new string[1];
            int part = 0;
            int itemInArray = 1;

            for (int i = 0; i < text.Length; i++)
            {
                if (IsIn(delim, text[i]))
                {
                    Array.Resize(ref result, ++itemInArray);
                    part++;
                }
                else
                    result[part] += text[i];
            }
            return result;
        }
        public static Boolean IsIn(char[] delim, char c)
        {
            for (int i = 0; i < delim.Length; i++)
                if (c == delim[i])
                    return true;
            return false;
        }
        #endregion
    }
}
