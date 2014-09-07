/* Question 17.10
 
Since XML is very verbose, you are given a way of encoding it where each tag gets mapped
to a pre-defined integer value. the language/grammar is as follows:
Element      --> Tag attributes End children End
Attribute    --> Tag value
End          --> 0
Tag          --> some predefined mapping to int
Value        --> string value END
For example the following XML might be converted into the compressed string below 
(assuming a mapping of family -> 1, person -> 2, firstname -> 3, lastname -> 4, state -> 5).

<family lastname="AAA" state="CA">
  <person firstName="BBB">Message</person>
</family>

becomes:
1 4 AAA 5 CA 0 2 3 BBB 0 Message 0 0
Write code to print the encoded version of an XML element (passed in Element and Atribute objects).
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Xml.Linq;
    using System.Text;
    using System.Collections.Generic;
    #endregion

    public class Chapter17_Q10
    {
        public static string EncodeToString(XElement root)
        {
            throw new NotImplementedException();
        }

        private static void Encode(XElement root, StringBuilder sb)
        {
            throw new NotImplementedException();
        }

        private static void Encode(XAttribute attr, StringBuilder sb)
        {
            throw new NotImplementedException();
        }

        private static void Encode(string v, StringBuilder sb)
        {
            throw new NotImplementedException();
        }

        private static int GetTagCode(string tag)
        {
            switch (tag)
            {
                case "family":
                    return 1;
                case "person":
                    return 2;
                case "firstname":
                    return 3;
                case "lastname":
                    return 4;
                case "state":
                    return 5;
                default:
                    return -1;
            }
        }
    }
}
