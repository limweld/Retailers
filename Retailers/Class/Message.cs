using Retailers.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Retailers.Class
{
    class Message
    {

        DBPrefix DBPrefix = new DBPrefix();
        Database.DBMessages.DBInbox DBInbox = new Database.DBMessages.DBInbox();
        Database.DBMessages.DBOutbox DBOutbox = new Database.DBMessages.DBOutbox();
        //Database.DBMessages.DBOutbox outbox = new Database.DBMessages.DBOutbox();


        public bool IsValidNumber(string recipient)
        {
            bool valid = false;

            if (Regex.IsMatch(recipient, @"^\d+$") && recipient.Count() == 11)
                valid = true;

            return valid;
        }

        public string Prefix(string number)
        {
            string prefix = number.Substring(0, 4);

            List<DBPrefix> prefixList = DBPrefix.GetData();
            foreach (DBPrefix prefixCheck in prefixList)
            {
                if (prefixCheck.Smart.Contains(prefix))
                    return "Smart";
                else if (prefixCheck.Globe.Contains(prefix))
                    return "Globe";
                else if (prefixCheck.Sun.Contains(prefix))
                    return "Sun";
            }

            return null;
        }

        public string[] MessageSplitter(string message)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' }; //MESSAGE SPLITTER or PARSING
            string[] messageSplit = message.Split(delimiterChars); //SPLITTING THE MESSAGE RECEIVE
            if (messageSplit.Count() < 2) //CHECK IF MESSAGE CONTAINS 2 OR MORE WORDS
                return null;

            return messageSplit;
        }

        public void AddtoInbox(DateTime date, string sender, string message)
        {
            DBInbox.Add(date, sender, message);
        }

        public void AddtoOutBox(DateTime date, string sender, string message, string status)
        {
            DBOutbox.Add(date, sender, message, status);
        }

        public bool MessageDuplicate(string mess, string sender)
        {
            Database.DBMessages.DBInboxLog rec = Database.DBMessages.DBInboxLog.GetPrevLoad(sender,mess);
            if (rec != null)
                return true;
            
                return false;
        }

        public bool PrepaidCableParsing(string mess, string sender)
        {
           

            string message = mess.ToUpper();
            string[] words = message.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            Array arr = words;

               Database.DBRetailers ret = Database.DBRetailers.GetDataByWallet(sender);
               if (ret != null)
               {

                   Database.DBPrepaidCable.DBPrepaidCable preCable = Database.DBPrepaidCable.DBPrepaidCable.GetDataByCode(words[0].ToUpper());
                    
                   if(preCable != null)
                   {
                      
                               if(arr.Length == 4)
                               {
                                    try
                                    {
                                        if ( (float)(ret.Balance) >= (float)(Convert.ToDouble(words[2])- (Convert.ToDouble(words[2]) * Convert.ToDouble(.02))))
                                        {
                                            
                                            Database.DBPrepaidCable.DBPrepaidCards datalist = Database.DBPrepaidCable.DBPrepaidCards.GetDataByAmount(Convert.ToInt32(words[2]),preCable.Code);

                                            if (datalist != null)
                                            {

                                                float amountcoded = (float)(Convert.ToDouble(words[2]));
                                               
                                                float discount = amountcoded * (float)(0.02);

                                                Database.DBTransactions.DBPrepaidCableTransactions transac = new Database.DBTransactions.DBPrepaidCableTransactions();
                                                transac.Add(sender, words[0], words[1], amountcoded, discount, datalist.Pin, words[3], DateTime.Now, "Sending");

                                                if (PhoneNumberParsing(words[3]) != "")
                                                {
                                                    //SEND TO CUSTOMER
                                                    if (words[0] == "CIGNAL" || words[0] == "DREAM")
                                                    {
                                                        AddtoOutBox(DateTime.Now, words[3], words[0] + " " + datalist.Pin + " " + words[1] + "\n" + preCable.Gateway, "Pending");
                                                    }

                                                    //sky or Gsat
                                                    if (words[0] == "SKY" || words[0] == "GSAT")
                                                    {
                                                        AddtoOutBox(DateTime.Now, words[3], words[0] + " " + words[1] + " " + datalist.Pin + "\n" + preCable.Gateway, "Pending");
                                                    }

                                                    return true;
                                                }

                                                AddtoOutBox(DateTime.Now, sender, "Invalid Customer Number.", "Pending");
                                                return false;
                                            }
                                            
                                            AddtoOutBox(DateTime.Now, sender,"Amount : "+ words[2]+ " Code : "+words[0]+" None Available", "Pending");
                                          
                                            return false;
                                            
                                        }
                                        //youWallet is none enough
                                        AddtoOutBox(DateTime.Now, sender, "Your balance is " + ret.Balance + " None enough", "Pending");
                                        return false;

                                    }
                                    catch (Exception ex)
                                    {
                                        ex.ToString();
                                        //No Code Amount Detected
                                        AddtoOutBox(DateTime.Now, sender, "Invalid Code ! must be a Number Amount : "+words[2], "Pending");
                                        return false;
                                    }
                            }
                               AddtoOutBox(DateTime.Now, sender, "Incomplete Command, please check your message format.", "Pending"); 
                            return false;
                        
                    }
                   
                    //**sendPending/***Invalid first Primary Code 
                    AddtoOutBox(DateTime.Now, sender, "Invalid Primary Code, please check your message format.", "Pending");
                    return false;
                }
                //Invalid Sender Unregistered Wallet
                //No reply... 
               return false;
      

        }

        public static void PrepaidCableConfirmationCustomer()
        {
           try{
                    string mess,mess1;
                    mess = mess1 = "";
                    Database.DBTransactions.DBPrepaidCableTransactions trs = Database.DBTransactions.DBPrepaidCableTransactions.GetDataSendingStatus("Sending");
                    Database.DBMessages.DBOutbox add = new Database.DBMessages.DBOutbox();   

                    if (trs != null)
                    {
                        Database.DBPrepaidCable.DBPrepaidCable preCable = Database.DBPrepaidCable.DBPrepaidCable.GetDataByCode(trs.Code);

                        Database.DBMessages.DBOutboxLog outbl1 = Database.DBMessages.DBOutboxLog.GetDataMessage(trs.Code + " " + trs.Box_number + " " + trs.Pin);

                        Database.DBMessages.DBOutboxLog outbl2 = Database.DBMessages.DBOutboxLog.GetDataMessage(trs.Code + " " + trs.Pin + " " + trs.Box_number);

                        Database.DBMessages.DBOutbox outb1 = Database.DBMessages.DBOutbox.GetDataMessage(trs.Code + " " + trs.Pin + " " + trs.Box_number,"Unsuccessful");

                        Database.DBMessages.DBOutbox outb2 = Database.DBMessages.DBOutbox.GetDataMessage(trs.Code + " " + trs.Box_number + " " + trs.Pin, "Unsuccessful");

                        if (outbl1 != null || outbl2 != null)
                        {
                            Database.DBPrepaidCable.DBPrepaidCable cabletype = Database.DBPrepaidCable.DBPrepaidCable.GetDataByCode(trs.Code);
                            Database.DBPrepaidCable.DBPrepaidCards cards = Database.DBPrepaidCable.DBPrepaidCards.GetDataByAmount(Convert.ToInt32(trs.Amount), cabletype.Code);
                            Database.DBPrepaidCable.DBPrepaidCardslog cardslog = new Database.DBPrepaidCable.DBPrepaidCardslog();
                            Database.DBPrepaidCable.DBPrepaidCards cards1 = new Database.DBPrepaidCable.DBPrepaidCards();

                            cardslog.Add(cabletype.Code, cards.Amount, cards.Pin, DateTime.Now, "Used");
                            cards1.Delete(Convert.ToString(cards.Id));

                            Database.DBRetailers wallet = Database.DBRetailers.GetDataByWallet(trs.Wallet_id);

                            Database.DBRetailers upd = new Database.DBRetailers();

                            float balance = wallet.Balance + trs.Discount - trs.Amount;

                            upd.UpdateBalance(wallet.Wallet_Id, balance);

                            var chars = trs.Pin.ToCharArray();

                            for (int x = chars.Length - 4; x >= 0; x--)
                            {
                                mess1 = chars[x] + mess1;
                            }

                            if (trs.Code == "CIGNAL" || trs.Code == "DREAM")
                                mess = trs.Code + " " + mess1 + "*** " + trs.Box_number;

                            if (trs.Code == "SKY" || trs.Code == "GSAT")
                                mess = trs.Code + " " + trs.Box_number + " " + mess1 + "***";


                           
                            add.Add(DateTime.Now, trs.Wallet_id, "A1+ : Successfully Transact ref#:" + trs.Id.ToString("D6") + " to " + trs.Customer_number + ". Current bal " + balance + ". \n" + mess +".", "Pending");

                            Database.DBTransactions.DBPrepaidCableTransactions update = new Database.DBTransactions.DBPrepaidCableTransactions();
                            update.Update(trs.Id, "status", "Sent");
                        }
                        else if (outb1 != null || outb2 != null)
                        {
                            Database.DBTransactions.DBPrepaidCableTransactions update = new Database.DBTransactions.DBPrepaidCableTransactions();
                            update.Update(trs.Id, "status", "Failed");

                            add.Add(DateTime.Now, trs.Wallet_id, " Transaction Failed !", "Pending");
              
                        }
                    }
                 }
                 catch(Exception ex)
                {
                        ex.ToString();
                        MessageBox.Show("Error Processing !");
                 }
                  
        }

        public bool PostpaidBillParsing(string mess, string sender)
        {

                string message = mess.ToUpper();
                string[] words = message.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                Array arr = words;
                if (words[0] == "PAY")
                {
                    Database.DBRetailers ret = Database.DBRetailers.GetDataByWallet(sender);
                    if (ret != null)
                    {

                        Database.DBPostpaidBill.DBPostpaidBill postBill = Database.DBPostpaidBill.DBPostpaidBill.GetDataByCode(words[1].ToUpper());

                        if (postBill != null)
                        {
                            if (arr.Length >= 5)
                            {
                                try
                                {
                                    if ((float)(ret.Balance) >= (float)(Convert.ToDouble(words[2]) + postBill.ServiceCharge))
                                    {

                                        if ((ParameterParsingWithSlash(ParameterStringParsing(mess))) == true)
                                        {

                                            string[] parameter = ParameterStringParsing(mess).Split("/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                                            Array parameters = parameter;

                                            string param2;
                                            try
                                            {
                                                param2 = parameter[1];
                                            }
                                            catch (Exception ex)
                                            {
                                                ex.ToString();
                                                param2 = "";
                                            }

                                            PostBillTransaction(parameter[0].ToUpper(), param2.ToUpper(), words[1], sender, (float)(Convert.ToDouble(words[2])), ret.Balance, FullNameStringParsing(mess, ParameterIntParsing(mess)), PhoneNumberParsing(words[arr.Length - 1]));

                                            return true;
                                        }

                                        AddtoOutBox(DateTime.Now, sender, "Invalid Parameter /  " + ret.Balance + " None enough", "Pending");
                                        return false;
                                    }
                                    //youWallet is none enough
                                    AddtoOutBox(DateTime.Now, sender, "Your balance is " + ret.Balance + " None enough", "Pending");
                                    return false;

                                }
                                catch (Exception ex)
                                {
                                    ex.ToString();
                                    //No Code Amount Detected
                                    AddtoOutBox(DateTime.Now, sender, "Invalid Code ! must be a Number Amount : " + words[2], "Pending");
                                    return false;
                                }
                            }
                            AddtoOutBox(DateTime.Now, sender, "Incomplete Command,  please check your message format.", "Pending");
                            return false;

                        }

                        //**sendPending/***Invalid first Primary Code 
                        AddtoOutBox(DateTime.Now, sender, "Invalid Primary Bill Code,  please check your message format.", "Pending");
                        return false;
                    }
                    //Invalid Sender Unregistered Wallet
                    //No reply... 
                    return false;
                }

                return false;
        }

        public bool MessageParsing(string mess, string sender)
        {
              if(MessageDuplicate(mess,sender)==false){


                    string[] word = mess.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    Array words = word;
                    
                    if (word[0].ToUpper() =="PAY")
                    {
                        PostpaidBillParsing(mess, sender);
                        return true;
                    }else{
               
                        PrepaidCableParsing(mess, sender);
                        return true;
                    }
              }
    

            return false;
        }

        public string ParameterStringParsing(string s)
        {
            string[] word = s.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Array words = word;

            if (word[4] == "/")
            {
                return word[3] + word[4] + word[5];
            }

            var charswords3 = word[3].ToCharArray();
            var charswords4 = word[4].ToCharArray();

            if (charswords3[charswords3.Length - 1] == '/')
            {

                return word[3] + word[4];
            }

            if (charswords4[0] == '/')
            {

                return word[3] + word[4];
            }


            return word[3];

        }

        public int ParameterIntParsing(string s)
        {
            string[] word = s.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Array words = word;

            if (word[4] == "/")
            {
                return 6;
            }

            var charswords3 = word[3].ToCharArray();
            var charswords4 = word[4].ToCharArray();

            if (charswords3[charswords3.Length - 1] == '/')
            {

                return 5;
            }

            if (charswords4[0] == '/')
            {

                return 5;
            }


            return 4;

        }

        public bool ParameterParsingWithSlash(string s)
        {
            string[] word = s.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Array words = word;

            string newString = "";

            for (int x = 0; x < words.Length; x++)
            {
                newString = newString + word[x];
            }

            int count = newString.Split('/').Length - 1;
            var chars = newString.ToCharArray();

            if ((chars[chars.Length - 1] == '/' || chars[0] == '/' || count != 1))
            {
                if (count == 0)
                {
                    return true;
                }

                return false;
            }

            return true;
        }

        public string FullNameStringParsing(string s, int index)
        {
            string[] word = s.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Array words = word;

            string newString = "";
            int range;
            var chars = word[words.Length - 1].ToCharArray();

            if (chars[0] == '0' || chars[1] == '9')
                range = words.Length - 1;
            else
                range = words.Length;

            for (int x = index; x < range; x++)
            {
                newString = newString + word[x] + " ";
            }

            return newString;
        }

        public static string PhoneNumberParsing(string s)
        {
            var chars = s.ToCharArray();

            if (chars.Length == 11)
            {

                for (int ctr = 0; ctr < chars.Length; ctr++)
                {
                    if (Char.IsNumber(chars[ctr]) == false)
                    {
                        return "";
                    }
                }

                return s;
            }

            return "";
        }
        
        public void PostBillTransaction(string param1,string param2,string billsCode,string wallet,float amount,float balance,string fullname,string customerNum){

            Database.DBRetailers upd = new Database.DBRetailers();
            Database.DBPostpaidBill.DBPostpaidBill postbills = Database.DBPostpaidBill.DBPostpaidBill.GetDataByCode(billsCode);

            float deduct = postbills.ServiceCharge + amount;
            float bal = balance - deduct;

            upd.UpdateBalance(wallet, bal);

            Database.DBMessages.DBOutbox add = new Database.DBMessages.DBOutbox();

            Database.DBTransactions.DBPostpaidBillTransaction billtrans = new Database.DBTransactions.DBPostpaidBillTransaction();
            billtrans.Add(DateTime.Now, billsCode,param1, param2, amount, wallet, "Pending", "", fullname, postbills.ServiceCharge,deduct,customerNum);

            Database.DBTransactions.DBPostpaidBillTransaction retrieve = Database.DBTransactions.DBPostpaidBillTransaction.GetDataLast();


            add.Add(DateTime.Now, wallet, "A1+ Payment System : Your " + billsCode + " bill has been accepted, payment posting is w/in 24hrs. Pls keep your tracking #" + retrieve.Id.ToString("D6")+". Current bal "+bal+".", "Pending");

            if (customerNum != "")
            {
                add.Add(DateTime.Now, customerNum, "Thank you using A1+ System. Your " + billsCode + " bill has been accepted, payment posting is w/in 24hrs. Pls keep yout tracking#"+ retrieve.Id.ToString("D6")+".", "Pending");
            }
        }
    }
}

