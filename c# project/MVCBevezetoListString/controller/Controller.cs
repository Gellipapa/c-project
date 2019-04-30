using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCBevezetoListString.repository;
using System.Diagnostics;

namespace MVCBevezetoListString.controller
{
    class Controller
    {
        private TajRepository tr;

        public Controller()
        {
            tr = new TajRepository();
        }

        public List<string> getNumbers()
        {
            List<double> numbers = tr.getTajnumber();
            List<string> numberString = new List<string>();

            foreach(double number in numbers)
            {
                numberString.Add(number.ToString());
            }
            return numberString;
        }
        public void addNumber(string numberText)
        {
            double number = 0;

            try
            {
                
                number = Convert.ToDouble(numberText);
                tr.add(number);
            }
            catch(FormatException fe)
            {
                throw new ControllerException(numberText+"szám nem megfelelő formátumú");
            }

            catch(OverflowException oe)
            {
                throw new ControllerException("A szám túl nagy vagy túl kicsi");
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Ismeretlen hiba történt" + ex.Message);
            }
            
        }

        public void modifyNumber(int index,string numberText)
        {
            double number = 0;
           
            try
            {
                number = Convert.ToDouble(numberText);
                tr.modify(index, number);
            }
            catch(RepositoryException re)
            {
                Debug.WriteLine(re.Message);
            }
            catch(FormatException fe)
            {
                throw new ControllerException(numberText + "a szám nem megfelelő formátumú");
            }
            catch(OverflowException oe)
            {
                throw new ControllerException(numberText + "a szám túl kicsi vagy túl nagy");
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Ismeretlen hiba történt...\n" + ex.Message);
            }
        }

        public void deleteNumber(int index)
        {
            try
            {
                tr.remove(index);
            }
            catch (RepositoryException re)
            {
                Debug.WriteLine(re.Message);
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Ismeretlen hiba történt...\n" + ex.Message);
            }
            
        }

        public string computeAverage()
        {
            try
            {
                double numbersAvg = tr.getAtlag();
                double roundednumber = Math.Round(numbersAvg, 2);
                return roundednumber.ToString();
            }
            catch(RepositoryException re)
            {
                Debug.WriteLine(re.Message);
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Ismeretlen hiba történt..\n" + ex.Message);
            }

            return "";
        }
    }
}
