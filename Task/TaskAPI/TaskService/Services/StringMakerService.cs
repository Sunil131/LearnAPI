using System;
using System.Text;
using TaskService.IServices;

namespace TaskService.Services
{
    public class StringMakerService : IStringMakerService
    {

        /// <summary>
        /// Generates the string on the basis of params passed
        /// </summary>
        /// <param name="minVal"></param>
        /// <param name="maxVal"></param>
        /// <returns>Returns the string of numbers from min to max with number divisible by 3 showing as Birch
        /// , 5 as Telecomm, and both 3 and 5 showing as BirchTelecomm </returns>
        public string MakeMyString(int minVal, int maxVal)
        {
            StringBuilder sbReturnString = new StringBuilder();
            try
            {
                while (minVal < maxVal)
                {
                    if ((minVal % 3) == 0 && (minVal % 5) != 0) //Condition to check if the number is only divisble by 3
                    {
                        sbReturnString.Append("Birch,");
                    }
                    else if ((minVal % 3) != 0 && (minVal % 5) == 0) //Condition to check if the number is only divisble by 5
                    {
                        sbReturnString.Append("Telecomm,");
                    }
                    else if ((minVal % 3) == 0 && (minVal % 5) == 0)//Condition to check if the number is only divisble by 3
                    {
                        sbReturnString.Append("BirchTelecomm,"); //NOTE: Incase min value is ZERO, ZERO is devided by both numbers so this case will come true
                    }
                    else
                    {
                        sbReturnString.Append(minVal.ToString() + ",");//If no  condition matched, simply append the number
                    }
                    minVal++;
                }
            }
            catch (Exception ex)
            {
                //Exceptions will be logged here, 
                throw new Exception("Unable to process request" + ex.Message); //for now we are just throwing it back with a custom message
            }
            return sbReturnString.ToString().TrimEnd(',');
        }
    }
}
