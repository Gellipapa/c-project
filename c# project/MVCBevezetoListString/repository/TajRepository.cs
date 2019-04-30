using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBevezetoListString.repository
{
    class TajRepository
    {
        private List<double> tajnumber;

        public TajRepository()
        {
           tajnumber = new List<double>();
        }

        public List<double> getTajnumber()
        {
            return tajnumber;
        }

        public void add(double number)
        {
            tajnumber.Add(number);
        }

        public void remove(int index)
        {
            

            try
            {
                tajnumber.RemoveAt(index);
            }
            catch(ArgumentOutOfRangeException e)
            {
                throw new RepositoryException(index + "sorszámú elem nem törölhető!\n+" + e.Message);
            }
        }

        public void modify(int index,double toNumber)
        {
            

            try
            {
                tajnumber[index] = toNumber;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new RepositoryException(index + "sorszámú elem nem törölhető\n" + e.Message);
            }
        }

        public double getAtlag()
        { 
              
            try
            {
                double atlag = tajnumber.Average();

                return atlag;

            }
            catch (ArgumentNullException ane)
            {
                throw new RepositoryException("A számok átlaga nem számolható" + ane.Message);
            }

            catch(InvalidOperationException ioe)
            {
                throw new RepositoryException("A számok átlaga nem számolható"+ioe.Message);
            }
        }


        

        
    }
}
