using EFMonkey;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Administration
{
    public class Message
    {
        //public int SaveMessage(int senderId, int receiverId, string messageText)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {
        //        EFMonkey.User userSender = context.User.First(u => u.Id == senderId);
        //        EFMonkey.User userReceiver = context.User.First(u => u.Id == receiverId);

        //        EFMonkey.Message message = new EFMonkey.Message();
        //        message.Sender = userSender;
        //        message.Receiver = userReceiver;
        //        message.Text = messageText;
        //        message.Read = false;

        //        context.Message.Add(message);
        //        context.SaveChanges();

        //        return message.Id;
        //    }
        //}

        //public void UpdateMessageRead(int senderId, int receiverId)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {   
        //        List<EFMonkey.Message> messages = context.Message.Include(y => y.Receiver).Include(y => y.Sender)
        //            .Where(m => (m.Sender.Id == senderId && m.Receiver.Id == receiverId && m.Read != true)).ToList();

        //        foreach(EFMonkey.Message message in messages)
        //        {
        //            message.Read = true;
        //        }
        //        context.SaveChanges();
        //    }
        //}

        //public void UpdateMessageReadTask(int userId, int taskId)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {
        //        List<EFMonkey.Message> messages = context.Message.Include(y => y.Task)
        //            .Where(m => (m.Task.Id == taskId && m.Task.TaskAssignee.Id == userId && m.Read != true)).ToList();

        //        foreach (EFMonkey.Message message in messages)
        //        {
        //            message.Read = true;
        //        }
        //        context.SaveChanges();
        //    }
        //}

        //public DataTable GetMessages(int senderId, int receiverId)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {
        //        EFMonkey.User userSender = context.User.First(u => u.Id == senderId);
        //        EFMonkey.User userReceiver = context.User.First(u => u.Id == receiverId);

        //        List<EFMonkey.Message> messages = context.Message.Include(y => y.Receiver).Include(y => y.Sender)
        //            .Where(m => (m.Sender.Id == senderId && m.Receiver.Id == receiverId) || (m.Sender.Id == receiverId && m.Receiver.Id == senderId)).ToList();

        //        DataTable table = new DataTable();
        //        if (messages.Count > 0)
        //        {
        //            table.Columns.Add("text");
        //            table.Columns.Add("isSender");
        //            table.Columns.Add("documentId");
        //            table.Columns.Add("documentName");

        //            foreach (EFMonkey.Message message in messages)
        //            {
        //                EFMonkey.Document document = null;
        //                int messageId = message.Id;
        //                if (context.Document.Where(d => d.Id == messageId).ToList().Count > 0)
        //                    document = context.Document.First(d => d.Id == messageId);

        //                DataRow row = table.NewRow();
        //                row["text"] = message.Text;
        //                row["isSender"] = message.Sender.Id == senderId;
        //                row["documentId"] = document != null ? document.Id.ToString() : "";
        //                row["documentName"] = document != null ? (document.Name.Split('&').Count() > 1 ? document.Name.Split('&')[1] : document.Name) : "";
        //                //row[""]
        //                table.Rows.Add(row);
        //                table.AcceptChanges();
        //            }
        //        }
        //        return table;

        //    }
        //}

        //public DataTable GetTopMessages(int userId, int number)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {
        //        EFMonkey.User userReceiver = context.User.First(u => u.Id == userId);

        //        List<EFMonkey.Message> messages = context.Message.Include(y => y.Receiver).Include(y => y.Sender)
        //            .Where(m => m.Receiver.Id == userId && m.Read != true).OrderByDescending(m => m.Id).Take(number).ToList();

        //        DataTable table = new DataTable();
        //        if (messages.Count > 0)
        //        {
        //            table.Columns.Add("text");
        //            table.Columns.Add("senderId");
        //            table.Columns.Add("nameSender");

        //            foreach (EFMonkey.Message message in messages)
        //            {
        //                string regString = StripHTML(message.Text);

        //                DataRow row = table.NewRow();
        //                row["text"] = regString.Length > 20 ? regString.Substring(0,19) : regString;
        //                row["senderId"] = message.Sender.Id;
        //                row["nameSender"] = message.Sender.FirstName + " " + message.Sender.LastName;
        //                table.Rows.Add(row);
        //                table.AcceptChanges();
        //            }
        //        }
        //        return table;
        //    }
        //}

        //public DataTable GetTopMessagesTasks(int userId)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {
        //        EFMonkey.User user = context.User.First(u => u.Id == userId);

        //        List<EFMonkey.Message> messages = context.Message.Include(y => y.Task)
        //            .Where(m => ((m.Task.TaskAssignee.Id == userId) && m.Sender.Id != userId && m.Read != true)).ToList();

        //        DataTable table = new DataTable();
        //        if (messages.Count > 0)
        //        {
        //            table.Columns.Add("name");
        //            table.Columns.Add("id");
        //            table.Columns.Add("nameSender");

        //            foreach (EFMonkey.Message message in messages)
        //            {
        //                string regString = StripHTML(message.Text);

        //                DataRow row = table.NewRow();
        //                row["name"] = message.Task.Name;
        //                row["id"] = message.Task.Id;
        //                row["nameSender"] = message.Sender.FirstName + " " + message.Sender.LastName;
        //                table.Rows.Add(row);
        //                table.AcceptChanges();
        //            }
        //        }
        //        return table;
        //    }
        //}

        //public string StripHTML(string input)
        //{
        //    return Regex.Replace(input, "<.*?>", String.Empty);
        //}

        //public DataTable GetCorporationMessages(int corporationId)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {
        //        List<EFMonkey.Message> messages = context.Message.Where(m => m.Sender.Corporation.Id == corporationId && m.Receiver == null && m.Task == null).ToList();

        //        DataTable table = new DataTable();
        //        if (messages.Count > 0)
        //        {
        //            table.Columns.Add("messageName");
        //            table.Columns.Add("messageText");
        //            table.Columns.Add("messageDate");
        //            table.Columns.Add("documentId");
        //            table.Columns.Add("documentName");

        //            foreach (EFMonkey.Message message in messages)
        //            {
        //                EFMonkey.Document document = null;
        //                int messageId = message.Id;
        //                if (context.Document.Where(d => d.Id == messageId).ToList().Count > 0)
        //                    document = context.Document.First(d => d.Id == messageId);

        //                DataRow row = table.NewRow();
        //                row["messageName"] = message.Sender.FirstName + " " + message.Sender.LastName;
        //                row["messageText"] = message.Text;
        //                row["messageDate"] = "";//message.UpdateDate;
        //                row["documentId"] = document != null ? document.Id.ToString() : "";
        //                row["documentName"] = document != null ? (document.Name.Split('&').Count() > 1 ? document.Name.Split('&')[1] : document.Name) : "";
        //                //row[""]
        //                table.Rows.Add(row);
        //                table.AcceptChanges();
        //            }
        //        }
        //        return table;
        //    }
        //}

        //public int AddCorporationMessage(string messageText, int senderId)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {
        //        EFMonkey.User userSender = context.User.First(u => u.Id == senderId);

        //        EFMonkey.Message message = new EFMonkey.Message();
        //        message.Sender = userSender;
        //        message.Text = messageText;
        //        message.Read = false;

        //        context.Message.Add(message);
        //        context.SaveChanges();

        //        return message.Id;
        //    }
        //}

        //public int AddMessageDocument(int messageId, int userId, string filename)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {
        //        EFMonkey.Document document = new EFMonkey.Document();
        //        EFMonkey.Message message = context.Message.First(t => t.Id == messageId);
        //        EFMonkey.User user = context.User.First(t => t.Id == userId);
        //        document.Name = filename;
        //        document.Message = message;
        //        document.DocumentOwner = user;

        //        context.Document.Add(document);
        //        context.SaveChanges();

        //        return document.Id;
        //    }
        //}

        //public string GetDocument(int documentId)
        //{
        //    using (EFMonkeyContext context = new EFMonkey.EFMonkeyContext())
        //    {
        //        EFMonkey.Document document = context.Document.FirstOrDefault(d => d.Id == documentId);
                

        //        return document.Name;
        //    }
        //}

    }
}
