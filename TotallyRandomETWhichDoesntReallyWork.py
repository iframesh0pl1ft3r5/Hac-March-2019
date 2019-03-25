#!/usr/bin/env python

# Iframesh0pl1ft3r5

# Import necessary modules


import smtplib, random
from email.mime.text import MIMEText

def ETPHONEHOME():
    # Set sender and receiver details
    sender = 'email@email.com'
    receiver = 'email@email.com'
    message = '[ | ]'
    password = 'password'
    

    # Set up localhost
    mail = smtplib.SMTP('smtp.gmail.com', 587)
    mail.ehlo()
    mail.starttls()
    mail.login(sender, password)
    
    msg = MIMEText('( ^ \_/ ^ )')
    msg['Subject'] = 'NECKS TO NO PUNS...'
    msg['From'] = sender
    msg['To'] = receiver

    mail.sendmail(sender, receiver, msg.as_string())

    msg2 = MIMEText('[ | ]')
    msg2['Subject'] = 'NECKS TO NO PUNS...'
    msg2['From'] = sender
    msg2['To'] = receiver

    neckNo = 4
    # Creates a loop to send each of the letters of the message
    for i in range(neckNo):
        randomNum = random.randint(1,neckNo)
        if randomNum > neckNo-3:
            main2()
        # Turn to list for converting to single characters
        mail.sendmail(sender, receiver, msg2.as_string())


    # Notifies us when done
    print('Messages successfully sent')

    # Close
    mail.close()
def main2():
    
    # Set sender and receiver details
    sender = 'xyziframe@gmail.com'
    receiver = 'example234134@gmail.com'
    #receiver = 'JoshuaG1000@outlook.com'
    password = 'thisexample'
    

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

def main():
    ETPHONEHOME()


# Run the main function
if __name__== '__main__':
    
    main()

