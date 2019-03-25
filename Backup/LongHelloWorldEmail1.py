#!/usr/bin/env python

# Iframesh0pl1ft3r5

# Import necessary modules
import smtplib
from email.mime.text import MIMEText

def main():
    # Set sender and receiver details
    sender = 'email@email.com'
    receiver = 'email@email.com'
    message = 'hello world'
    password = 'password'
    

    # Set up localhost
    mail = smtplib.SMTP('smtp.gmail.com', 587)
    mail.ehlo()
    mail.starttls()
    mail.login(sender, password)
    
    # Creates a loop to send each of the letters of the message
    for i in range(1, len(message)+1, 1):
        # Turn to list for converting to single characters
        msg = list(message)
        # Reverse the message
        msg.reverse()
        msg = msg[i-1]
        mail.sendmail(sender, receiver, msg+" "*20)
        print(message[i-1])

    # Notifies us when done
    print('Messages successfully sent')

    # Close
    mail.close()

# Run the main function
if __name__== '__main__':
    main()

