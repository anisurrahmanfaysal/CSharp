// See https://aka.ms/new-console-template for more information
using OODPrinciples.DIP;
using OODPrinciples.LSP;


IEmailSender emailSender = new HtmlEmailSender();

Membership membership = new Membership(emailSender);
