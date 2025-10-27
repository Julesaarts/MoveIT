using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    //Doel van deze klasse is om de UI te informeren over wat er precies fout gaat.
    public class RideResult
    {
        public bool Success { get; private set; }
        public string ErrorMessage { get; private set; }


        /// <summary>
        /// Succesful customer in vehicle //mag ok iets anders zijn
        /// </summary>
        public RideResult()
        {
            Success = true;
            ErrorMessage = string.Empty;
        }


        /// <summary>
        /// Unsuccessful customer in vehicle //mag ok iets anders zijn
        /// </summary>
        /// <param name="success"></param>
        /// <param name="errorMessage"></param>
        //Constructor overload
        public RideResult(string errorMessage)
        {
            Success = false;
            ErrorMessage = errorMessage;
        }
    }
}
