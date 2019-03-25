#!/usr/bin/env python

# Iframesh0pl1ft3r5

# Import necessary modules
import smtplib
from email.mime.text import MIMEText

def main():
    # Set sender and receiver details
    sender = 'email@email.com'
    receiver = 'email@email.com'
    password = 'password'
    

    # Set up localhost
    mail = smtplib.SMTP('smtp.gmail.com', 587)
    mail.ehlo()
    mail.starttls()
    mail.login(sender, password)

    # Variables from form
    refer = 'Mr'
    firstName = "John"
    lastName = "Smith"

    # Put url there
    msg = MIMEText('{0},\n\nPlease verify your email at this website: www.google.com\nIf this is not you, please ignore this email.\nKind Regards,\n\nThe Iframesh0pl1ft3r5 Team'.format(firstName))


    msg['Subject'] = '{0} {1}.{2}, We need you to verify that you are real'.format(refer, firstName[0], lastName)
    msg['From'] = sender
    msg['To'] = receiver

    mail.sendmail(sender, receiver, msg.as_string())
    
    # Notifies when done
    print('Successfully sent')

    # Close
    mail.close()

# Run the main function
if __name__== '__main__':
    main()

