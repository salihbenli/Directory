# Directory

Telephone Directory

It is a phone book application with a simple structure that can be used in web or mobile applications.

Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 
See deployment for notes on how to deploy the project on a live system.

Prerequisites

In order to test and re-project the software, visual studio and SQL server programs must be installed on your local computer.

Installing

 Before installing the project, you should import the sql database I will give you to your local computer.

1)	CREATE DATABASE [Directory]

2)	CREATE TABLE [dbo].[Contacts](
	[UUID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Company] [nvarchar](max) NULL,
 	CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[UUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

3)	CREATE TABLE [dbo].[Informations](
	[InfoID] [int] IDENTITY(1,1) NOT NULL,
	[Telephone_Number] [nvarchar](max) NULL,
	[E_Mail] [nvarchar](max) NULL,
	[Location] [nvarchar](max) NULL,
	[Info] [nvarchar](max) NULL,
	[UUID] [int] NOT NULL,
	[ContactUUID] [int] NULL,
 CONSTRAINT [PK_Informations] PRIMARY KEY CLUSTERED 
(
	[InfoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

4.	ALTER TABLE [dbo].[Informations]  WITH CHECK ADD  CONSTRAINT [FK_Informations_Contacts_ContactUUID] FOREIGN KEY([UUID])
REFERENCES [dbo].[Contacts] ([UUID])
ON DELETE CASCADE
GO

5.	ALTER TABLE [dbo].[Informations] CHECK CONSTRAINT [FK_Informations_Contacts_ContactUUID]
GO

Follow steps 1-2-3-4-5 respectively. After these processes, you are ready to open the project in visual studio.

Working Principles

The first welcome screen awaits you. From here you can go to the contacts menu to see the contact list, 
to the add contacts menu to add a contact, and finally to the report menu to see the reports.
 







From the contact list menu, you can delete, edit, add contact information of the person on the existing contacts.
When you click on the name of the person, the contact information of the person will be listed. You can delete and edit the listed information.
 
 
 
 
You can add new contacts to the contacts from the add contacts menu. 










On the report page, it is possible to see how many people in which city and the phone numbers of the people added to the directory,
from largest to smallest. You can also shorten the list by city with the search feature.  







Built With - 
•	 .NET Core 
•	 Git 
•	 MSSQL 
•	 Redis 

Author -
Salih BENLİ
