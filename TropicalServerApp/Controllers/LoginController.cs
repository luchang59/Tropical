using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TropicalServerApp.ViewModel;
using TropicalServerApp.Models;
using TropicalServer.BLL;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace TropicalServerApp.Controllers
{
    public class LoginController : Controller
    {
        // static user object 
        // GET: Login
        public ActionResult Login()
        {
            string UserID = checkCookie();
            if (UserID == string.Empty)
                return View();
            else
            {
                HttpCookie ckUserID = new HttpCookie("userID");
                ckUserID.Expires = DateTime.Now.AddSeconds(3600);
                ckUserID.Value = UserID;
                Response.Cookies.Add(ckUserID);
                return View();
            }
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            /*if (Response.Cookies["userID"] != null)
            {
                HttpCookie ckUserID = new HttpCookie("userID");
                ckUserID.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(ckUserID);
            }*/
            return View("Login");
        }

        public ActionResult Submit(AccountViewModel obj)
        {
            if (ModelState.IsValid)
            {
                string UserID = obj.account.UserID;
                string Password = obj.account.Password;
                DataSet data = new ReportsBLL().ValidateAccount_BLL(UserID, Password);
                DataRowCollection row = data.Tables[0].Rows;
                if (row.Count == 0)
                {
                    ModelState.AddModelError("Login", "Your account information was entered incorrectly.");
                    return View("Login");
                }
                else
                {
                    Session["userObj"] = row;
                    if (obj.remember == true)
                    {
                        HttpCookie ckUserID = new HttpCookie("userID");
                        ckUserID.Expires = DateTime.Now.AddSeconds(3600);
                        ckUserID.Value = UserID;
                        Response.Cookies.Add(ckUserID);
                    }
                    return RedirectToAction("Orders", "Product");
                }
            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult ForgotUsername()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }
        
        public ActionResult SendEmail(UserLogin obj)
        {
            if(obj.EmailID != null)
            {
                string userInfo = obj.EmailID;
                DataSet data = new ReportsBLL().GetEmail_BLL(obj.EmailID);
                DataRowCollection row = data.Tables[0].Rows;
                if (row.Count != 0)
                {   
                    string email = row[0]["EmailID"].ToString();
                    string userID = row[0]["UserID"].ToString();
                    var smtpClient = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential("changlu591@gmail.com", "iwmnhxdqhrdxlqgp"),
                        EnableSsl = true,
                };

                    smtpClient.Send("changlu591@gmail.com", email, "Here is your user id", $"Your user ID is {userID}");
                }
            }
            else if (obj.UserID != null)
            {
                string userInfo = obj.UserID;
                DataSet data = new ReportsBLL().GetEmail_BLL(obj.UserID);
                DataRowCollection row = data.Tables[0].Rows;
                if (row.Count != 0)
                {
                    string email = row[0]["EmailID"].ToString();
                    var smtpClient = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential("changlu591@gmail.com", "iwmnhxdqhrdxlqgp"),
                        EnableSsl = true,
                    };

                    smtpClient.Send("changlu591@gmail.com", email, "Please reset your password", "Please use this link: https://www.google.com");
                }
            }
            else
            {
                return View("Login");
            }
            return View("Login");
        }

        public string checkCookie()
        {   
            string userID = string.Empty;
            if(Request.Cookies["userID"] != null)
            {
                userID = Request.Cookies["userID"].Value;
            }
            return userID;
        }
    }
}