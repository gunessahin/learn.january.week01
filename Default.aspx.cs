// Namespace
namespace learn.january.week01
{
    // Referance
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Form Controller
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {
        #region Property
        // Total  Number
        public int total { get; set; }
        // Message
        public string message { get; set; }
        #endregion

        /// <summary>
        /// Sum Event
        /// 
        /// - Oluşturulan bir formda
        /// - iki text alanından
        /// - birinci alana girilen sayıdan + ikinci alana girilen sayıya kadar olan sayıların toplamını
        /// - alan program kodlarını yazınız
        /// 
        /// - İlk sayı > ikinci sayıdan büyükse = hata mesajı verecektir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSum_Click(object sender, EventArgs e)
        {
            // Check is Numeric [ extension ]
            int firstNumeric, secondNumeric;
            bool firstIsNumeric = isNumeric(stringData: txtFirst.Text, position: "İlk Sayı", numeric: out firstNumeric);
            bool secondIsNumeric = isNumeric(stringData: txtSecond.Text, position: "İkinci Sayı", numeric: out secondNumeric);

            // Check Big
            bool isBig = IsBig(firstData:firstNumeric, secondData:secondNumeric);

            // Procress Control
            if (firstIsNumeric && secondIsNumeric && !isBig)
            {
                // Total Two Number Sum Proc
                // total = Sum(firstNumeric, secondNumeric);

                // Total Two Number Sum Range Proc
                total = SumRange(firstNumeric, secondNumeric);
            }

            // Message Write
            Message(message: message);
        }

        /// <summary>
        /// Is Numeric
        /// </summary>
        /// <param name="stringData"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool isNumeric(string stringData, string position, out int numeric)
        {
            // Check is Numeric
            bool result  = int.TryParse(stringData, out numeric);

            // Extention Application
            if (!result)
            {
                // Message Format
                message += string.Format("{0} {1} numeric olmalıdır!\n", position, stringData);
            }

            return result;
        }

        /// <summary>
        /// İlk sayı > ikinci sayıdan büyükse = hata mesajı verecektir.
        /// </summary>
        private bool IsBig(int firstData, int secondData)
        {
            // Define
            bool result = false;

            // Check Big
            if (firstData > secondData)
            {
                // Message Format
                message += string.Format("İlk sayı {0} > {1} ikinci sayıdan büyük!\n", firstData, secondData);

                // Return
                result = true;
            }

            // Return
            return result;
        }
        
        /// <summary>
        /// Sum Proc
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        private int Sum(int first, int second)
        {
            // Define
            int result = 0;

            // Proc
            result = first + second; 

            // Message Format
            message += string.Format("Toplam: {0}\n", result);

            // Return
            return result;
        }

        /// <summary>
        /// Sum Range Proc
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        private int SumRange(int first, int second)
        {
            // Define
            int result = 0;

            // Proc
            result = first;
            int x = first;
            do
            {
                x++;
                result += x;

            } while (x < second);

            // Message Format
            message += string.Format("Toplam: {0}\n", result);

            // Return
            return result;
        }

        /// <summary>
        /// Message
        /// </summary>
        /// <param name="message"></param>
        private void Message(string message)
        {
            // Set Form Label Message
            lblMessage.Text = message;
        }
    }
}