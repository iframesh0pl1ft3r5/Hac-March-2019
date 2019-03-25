#!/usr/bin/env python

# Iframesh0pl1ft3r5

# Import necessary modules
import smtplib

def main():
    # Set sender and receiver details
    sender = 'email@email.com'
    receiver = 'email@email.com'
    message = 'Hello, World'
    password = 'passsword'
    
    # Set up localhost
    mail = smtplib.SMTP('smtp.gmail.com', 587)
    mail.ehlo()
    mail.starttls()

    # Log in to the sender account
    mail.login(sender, password)

    # Reverse the message
    message = list(message)
    message.reverse()

    # Creates a loop to send each of the letters of the message
    for i in range(1, len(message)+1, 1):
        mail.sendmail(sender, receiver, message[i-1])
        print(message[i-1])

    # Notifies when done
    print('Successfully sent')

    # Close
    mail.close()

# Run the main function
if __name__== '__main__':
    main()

