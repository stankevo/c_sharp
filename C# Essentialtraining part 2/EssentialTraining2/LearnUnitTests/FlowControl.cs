using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining2
{
    public class FlowControl
    {
        public bool IsYourFavoriteColorBlue(string color)
        {
            if (color.ToLower() == "blue")
            {
                return true;
            } else
            {
                return false;
            }
        }

        // more terse way to do same
        public bool IsYourFavoriteColorRed(string color)
        {
            if (color.ToLower() == "red") return true;
            return false;
        }

        // even more terse way to do same
        public bool IsYourFavoriteColorGreen(string color)
        {
            return (color.ToLower() == "green") ? true : false;
        }

        // the most terse way to do same even without if clause
        public bool IsYourFavoriteColorYellow(string color)
        {
            return (color.ToLower() == "yellow");
        } 

        //if-else, if-else statements
        public string PrimaryOrSecondary(string color)
        {
            var result = "";
            if (color.ToLower() == "red")
            {
                result = "Primary";
            }
            else if (color.ToLower() == "blue")
            {
                result = "Primary";
            }
            else if (color.ToLower() == "yellow")
            {
                result = "Primary";
            } else
            {
                result = "Secondary";
            }
            return result;
        }

        //switch statement
        public string SecondaryOrPrimary(string color)
        {
            var result = "";

            switch (color.ToLower())
            {
                case "red":
                    result = "Primary";
                    //you can put more lines of code here
                    break;

                case "blue":
                    result = "Primary";
                    break;

                case "yellow":
                    result = "Primary";
                    break;

                default:
                    result = "Secondary";
                    break;
            }

            return result;
        }

        //compound logic with logical OR ||
        public string PrimaryOrSecondaryCompound(string color)
        {
            if (color.ToLower() == "red" || color.ToLower() == "blue" || color.ToLower() == "yellow") return "Primary";
            return "Secondary";
        }

        //compound logic with logical AND &&
        public char GradeLetter(int score)
        {
            if (score >= 90)
            {
                return 'A';
            }
            else if (score > 79 && score < 90)
            {
                return 'B';
            }
            else if (score >= 70 && score <= 80)
            {
                return 'C';
            } else
            {
                return 'F';
            }
        }

        //logical NOT
        public string IsYourNameNotBruce(string yourName)
        {
            if (yourName.ToLower() != "bruce")
            {
                return "Can we call you Bruce for the sake of simplicity?";
            } else
            {
                return "G'day Bruce.";
            }
        }
    }
}
