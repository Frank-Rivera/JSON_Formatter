using System;
using JSON_Formatter.Library.Interfaces;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace JSON_Formatter.Library
{
    internal class PrettyJSONFormatter : IPrettyJSONFormatter
    {

     

        #region Properties

        public string RawString { get; set; }

        private static readonly char[] LeftCharacters = { '{', '[' };

        private static readonly char[] RightCharacters = { '}', ']' };

        private static readonly char FieldDelemeter = ',';

        private List<Char> Padding { get; set; }


        #endregion

        #region Constructors

        public PrettyJSONFormatter(string rawString) {
            this.RawString = rawString;
            this.Padding = new List<Char>();
        }

        #endregion

        #region Public Methods

        public string GetFormattedString()
        {

            StringBuilder stringBuilder = new StringBuilder(string.Empty);

            var charArry = this.RawString.ToCharArray();

            foreach (char chr in charArry) {

                if (LeftCharacters.Contains(chr))
                {
                    Padding.Add('\t');
                    stringBuilder.Append(string.Concat(chr.ToString(),Environment.NewLine, new string(Padding.ToArray())));                    
                }
                else if (RightCharacters.Contains(chr))
                {
                    Padding.RemoveAt(0);
                    stringBuilder.Append(string.Concat(Environment.NewLine, new string(Padding.ToArray()),  chr.ToString()));
                    
                }
                else if (chr.Equals(FieldDelemeter))
                {
                    stringBuilder.Append(string.Concat(chr.ToString(), Environment.NewLine, new string(Padding.ToArray())));
                }
                else {
                    stringBuilder.Append(chr.ToString());
                }


            }

            return stringBuilder.ToString();

        }

        #endregion


    }
}
