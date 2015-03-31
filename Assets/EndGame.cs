
using UnityEngine;
using System.Collections;
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;


public class EndGame : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GameObject camera = GameObject.Find("Main Camera");
		GameObject player = GameObject.Find("Player");
		GameObject score = GameObject.Find("Score");
		GameObject playerFeet = GameObject.Find("PlatFormerFeet");
		GameObject go = GameObject.Find ("Score");
		GameObject black = GameObject.Find ("Black");
		ScoreCounter sc = (ScoreCounter)go.GetComponent (typeof(ScoreCounter));
		if (sc.score >= 500) {
			print ("WQFFZFSDF");

			//anim.SetTrigger("end");
			//animBG.SetTrigger("end");
			SendEmailF();
			//System.Threading.Thread.Sleep(1000);

			Destroy(camera);
			Destroy(player);
			Destroy(score);
			Destroy(playerFeet);

			Application.LoadLevel("end");
		}
				
	}
	private void wait(float x){


		int count = 0;
		
		while(count < x){ 
			count ++;
			print (count);
		}

		
	}
	
	
	private void SendEmailF(){
		MailMessage mail = new MailMessage();
		
		mail.From = new MailAddress("kurosora3000@gmail.com");
		mail.To.Add("kan_swetha@yahoo.com");
		mail.Subject = "Dollah Master";
		mail.Body = "You have earned back your $5.00 back. Congrats!!! Expect to have your money back into your account within the week. Have a great day!";
		
		SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
		
		SmtpServer.Port = 587;
		//SmtpServer.Credentials = new System.Net.NetworkCredential("swethak@andrew.cmu.edu", "SeaQueen312^^");
		SmtpServer.Credentials = new System.Net.NetworkCredential("kurosora3000@gmail.com", "swe0nivi") as ICredentialsByHost;
		SmtpServer.EnableSsl = true;
		ServicePointManager.ServerCertificateValidationCallback = 
			delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) 
		{ return true; };
		SmtpServer.Send(mail);
		Debug.Log("success");
	}

}
