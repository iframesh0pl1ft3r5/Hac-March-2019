import smtplib
from email.mime.multipart import MIMEMultipart
from email.mime.text import MIMEText

def main():
    sender = 'email@email.com'
    receiver = 'email@email.com'
    message = 'Hello, World'
    password = 'password'
    
    msg = MIMEMultipart()
    msg['From'] = receiver
    msg['To'] = sender
    msg['Subject'] = 'Please Verify'
    msg['Body'] = message
    msg.preamble = 'Hello'
    

    mail = smtplib.SMTP('smtp.gmail.com', 587)
    mail.ehlo()
    mail.starttls()
    mail.login(sender, password)

    message = list(message)
    message.reverse()
    for i in range(1, len(message)+1, 1):
        mail.sendmail(sender, receiver, message[i-1])
        print(message[i-1])
        
    print('Successfully sent')
    mail.close()

if __name__== '__main__':
    main()
