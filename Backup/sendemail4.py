#!/usr/bin/env python

# Iframesh0pl1ft3r5

# Import necessary modules
import smtplib
from email.mime.text import MIMEText

def main():
    # Set sender and receiver details
    sender = 'email@email.com'
    receiver = 'email@email.com'
    message = 'Hello World'
    password = 'password'
    

    # Set up localhost
    mail = smtplib.SMTP('smtp.gmail.com', 587)
    mail.ehlo()
    mail.starttls()
    mail.login(sender, password)
    
    # Creates a loop to send each of the letters of the message
    for i in range(1, len(message)+1, 1):
        msg = list(message)
        # Reverse the message
        msg.reverse()
        msg = msg[i-1]
        
        
        


    
    
        mail.sendmail(sender, receiver, msg)
        print(message[i-1])

    # Put url there
    msg = MIMEText('Please verify your email at this website: www.google.com')

    msg['Subject'] = 'Verify at '
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

