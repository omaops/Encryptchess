# Encryptchess
The file encryptor for the four-digit Elo chess player. 

## Introduction
Have you ever heard of the saying “There are more possible games of Chess than atoms in the Universe” . Well, it’s not that large but it is large enough for this. Knowing your chess can sometimes come in handy. Welcome to Encryptchess. The file encryptor for the four-digit Elo chess player. This allows you to encrypt any file with chess moves. The better the player the better the encryption.
This uses AES-256 as the encryption algorithm. It just makes it a lot simpler for a chess player to lock a file with a move list which can be an opening, middle game or end game sequence.

## Requirement
- This is a C# desktop application so windows only for now.
- You need the latest .NET framework (If you’re on windows, you most probably already have it)

## Installation
Just download (Extract if Zipped) and open it.

## Usage
This is a software that encrypts data. Please make sure that you can also decrypt it back using the software before deleting original file. Read the Disclaimer section very carefully.

### To Encrypt
1.	Open the application.
2.	Click on the lock menu on top.
3.	Select the file you want to encrypt.
4.	Now at the top, it will say file is selected for locking and the board becomes active.
5.	Now the chess board will be active so you can input your moves. (Illegal moves are accepted)
a.	Drag and drop doesn’t work.
b.	You need to click at least on one square before submitting a move.
c.	Click on the square a piece is and click on another square you want to move the piece to. (Subjective to your thoughts so go nuts BUT remember the pattern)
6.	Now once you made a move sequence, click on submit move (greenish) at the top.
7.	DONE. An encrypted copy of your file is now generated. There will be a new file with <Original File Name>.aes
8.	The original file stays untouched.

### To Decrypt
1.	Open the application.
2.	Click on the Unlock menu on top.
3.	Select the file you want to decrypt (the one you encrypted before with THIS application).
4.	Now at the top, it will say file is selected for unlocking and the board becomes active.
5.	Now the chess board will be active so you can input your moves that you used to lock (encrypt) the file. 
a.	Drag and drop doesn’t work.
b.	You need to click at least on one square before submitting a move.
c.	Click on the square a piece is and click on another square you want to move the piece to.
6.	Now once you made the move sequence you locked the file with, click on submit move (reddish) at the top.
7.	DONE. A decrypted copy of your file is now generated. There will be a new file with <Original File Name_unlocked>.<Original File Extension>
8.	The encrypted file stays untouched.

### Clear
•	This allows you to start over. So click on ‘Clear’ if you are in any doubt before submitting your move.
### Show/Hide Coordinates
•	This simply allows you to see the board coordinates to display or hide.
### Help
•	If you need more info on the app and the developer. You can go nuts here.

# FAQ
1.	The board is inactive. I can’t click on anything.
- You need to chose a file you want to lock or unlock first.
2.	Do I need to confirm my moves again?
- No. I didn’t see a need for it as you can confirm by your self by decrypting the data back can checking. The original file is not altered in the process.
3.	It says it decrypted it but I can’t read the file.
- That’s because you didn’t use the correct move set you used originally! Encryption works that way. The key will define the output of the decryption to put it bluntly. If you didn’t put the correct move, you will not see the correct data. But there will be unreadable data!
4.	Did you make your own encryption algorithm?
- God No! Never roll your own crypto. This uses AES-256.
5.	Is this just an 8x8 num pad with unique values?
- That’s one way of seeing it as illegal moves are allowed. Next versions will allow you to chose to enable or disable illegal moves or to allow you to see pieces. The sky is the limit.
6.	Why can’t I see the piece on the board?
- This is a security feature. There is a reason password are hidden when you type them. But most importantly, I finished this in an afternoon (felt too lazy to implement the pieces)
7.	Is there any way of recovering my data if I forget my move list?
- No. On the bright side, you have unlimited tries.
8.	I can’t find my issues here!
- Email me at omaops@gmail.com and I’ll see what I can do BUT no promises.

# DISCLAMER
Copyright 2023, OMAOPS
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

