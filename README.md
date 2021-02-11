# PEC Drive
<div></div>

### Making your data saving devices more secure and reliable. Introducing PEC Drive, embedded with the functions of compression and encryption of the data. Its small size as compared to bulky and fat hard drives which makes it more portable and easy to carry.
<div></div>

## Need of this project:

<p>The Project, presented here, is to build a portable mass storage device such as a USB flash drive (16GB) or a Memory Card with installed software, which can compress large amounts of sensitive data and encrypt it by using asymmetric encryption. The compression is being done so data, of large size, can be carried easily from one place to another in our physical storage device. The asymmetric or symmetric encryption algorithm, named RSA (Rivest, Shamir, and Adelman), is being used to guarantee the security of the data if it is lost or confiscated. After receiving the compressed and encrypted data, the receiver will be able to decrypt and decompress the data to get the original form, by using the same software, in the USB flash drive.</p>
<div></div>

## Software Development:

### For Software developemnt of this project following languages were used;
* C# as a backend language, for more of its advanced features such as easily compilation with the `MONO` which allows applications built in C# language to run on various cross-platforms such as the LINUX, ARM Devices etc.
* .NET framework due to its enriched libraries regarding `MONO` which helps the applications to run on cross platforms and as it supports the development of various desktop based software applications.
* Windows Forms App for the designing and structuring of the front-end of the application. I used WFA because of its easy integration and execution time period. As it will help the compiler to compile the resources and execute them in a minimal period of time.
* IOT core for an easy integration and execution of the software on the IOT based devices or ARM architectured devices. This helps the user to execute a series of low level commands to make the device perform certain actions as instructed.
<div></div>

### For Hardware part following devices were used;
* For storing the data I used Arduino UNO, cause it helps in writing and reading the data on the memory sd card or USB flash drive. Due to low memory of the Arduino UNO, a seperate module for increasing its memory can be added by just connecting the ground points and voltage points of Arduino with the sd card module.
* For transferring of data from Arduino to PC, and from PC back to Arduino, STMF32 with F103 series was used in order to gain the transfer speed of the data, to and from the module.
<div></div>

## Working of the Project:

##### Following are some pictures added to illustrate the working of the project.

![workingonpc](https://github.com/AliRaza954/PEC-Drive/blob/master/images/IMG_20200927_221354.jpg)
<div></div>

### Ending Note:
  The target speed of compression is not achieved yet, so still its under development. `PEC Drive Version 3.0` will be released soon. So stay tuned.  
