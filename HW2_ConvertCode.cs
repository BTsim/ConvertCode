using System;
using System.ComponentModel;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            //CONVERSION (explicit, implicit, Convert)

            //1. CHAR CONVERSION 
            char sex = 'М';//to string
            string sex1 = Convert.ToString(sex); //"M"

            char place = '3';//to int
            int place1 = Convert.ToInt32(place);//"51"

            char hasFingerPrints = '0';//to boolean
            string hasFingerPrints1 = Convert.ToString(hasFingerPrints);//"0"
            int hasFingerPrints2 = Convert.ToInt32(hasFingerPrints1);//"0"
            bool hasFingerPrints3 = Convert.ToBoolean(hasFingerPrints2);//"False"


            //2. STRING CONVERSION           
            string hasPhotoString = "True";//to bolean
            bool hasPhotoString1 = Convert.ToBoolean(hasPhotoString);//"True"

            string flatNumber = "34";//to int
            int flatNumber1 = Convert.ToInt32(flatNumber);//"34"

            string visaPriceString = "34,23";//to float
            float visaPriceString1 = Convert.ToSingle(visaPriceString);//"32,32"

            string photoPriceString = "7.23";//to float

            // это сделат не получилось, точку не воспринимает, прочитал в интернете, что можно изменить CultureInfo, но пока сделать этого не получилось


            //3. BOOL CONVERSION
            bool hasFree2Pages = false;//to string, to char, to int
            string hasFree2Pages1 = Convert.ToString(hasFree2Pages);//"False"
            int hasFree2Pages2 = Convert.ToInt16(hasFree2Pages);//"0"
            char hasFree2Pages3 = Convert.ToChar(hasFree2Pages2);//" "

            //4. DECIMAL CONVERSION
            double visaPrice = 60;//to int, to string
            int visaPrice1 = Convert.ToInt16(visaPrice);//"60"
            string visaPrice2 = Convert.ToString(visaPrice);//"60"

            double finterPrintsPrice = 55.2;//to int, to string
            int finterPrintsPrice1 = Convert.ToInt16(finterPrintsPrice);//"55"
            string finterPrintsPrice2 = Convert.ToString(finterPrintsPrice);//"55,2"



            //4. INT CONVERSION
            int birthYear = 2000;//to string, to double, to char
            string birthYear1 = Convert.ToString(birthYear);//"2000"
            double birthYear2 = Convert.ToDouble(birthYear);//"2000"
            char birthYear3 = Convert.ToChar(birthYear);//"?"

            char birhtYearChar = (char)birthYear;

            int hasPhotoInt = 1;//to boolean
            bool hasPhotoInt1 = Convert.ToBoolean(hasPhotoInt);//"True"
        }
    }
}
