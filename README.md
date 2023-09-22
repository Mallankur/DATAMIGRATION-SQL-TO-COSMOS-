# DATAMIGRATION-SQL-TO-COSMOS-
Migrate_ALL_Data_from_SQL_TO_COSMOS_
  Objective: 
 Automating Data Transfer from SQL to Cosmos Using Azure Data Factory



![image](https://github.com/Mallankur/DATAMIGRATION-SQL-TO-COSMOS-/assets/109284107/0ec7f4f8-fe06-4c6b-9729-badd0f59e072)



Implementation Steps :
1.	Azure Data Factory Deployment
1.1.	Azure Data Studio's
2.	SQL Database and Cosmos DB Configuration
3.	Data Pipeline Design
4.	Data Movement Initiatives
5.	Triggering Automation
6.	Security and Access Controls
7.	Testing and Validation

1.	Azure Data Factory Deployment
Login in to Azure Portal and Create an Azure Data Factory resource in the Azure Portal. This resource acts as the central hub for orchestrating our data integration processes. For this We follow Several Steps.
STEP : 1 

1.	Create Resource: Go to ‘Create a Resource’ > “Data + Analytics” > “Data Factory”.
 
Figure 2 : Deployment of Azure Factory in Azure Cloude
STEP : 2

2) Configuration:   We provided essential configuration details for our Data Factory resource. If ok, proceed by clicking “Review and Create” to provision the Data Factory resource.

a.	You will be redirected to the configuration page shown in the image below to deploy the template. Here, you only need to create a new resource group. (You can leave all the other values with their defaults.) Then click Review + create and click Create to deploy the resources.
 
 
Figure 3 Azure Data Factory Deployment

         b) Review deployed resources 
                      Select Go to resource group after your deployment is complete. 

 

STEP :  3
•	Select the data factory in the resource group to view it. Then select the Launch Studio button to continue.
3.1	 Azure Data Studio - Home: Select the data factory in the resource group to view it. Then select the Launch Studio button to continue.

 
                                                                                  Figure 4 : Azure Data Factory Studio![image](https://github.com/Mallankur/DATAMIGRATION-SQL-TO-COSMOS-/assets/109284107/dffcf90d-73b8-4ed5-92de-47d20ecbbcbf)

 
Figure 5: Panel Overview of the Data Pipeline


3.1	Mange Azure Data Factory Studio:


STEP :  4
a)	SQL Database and Cosmos DB Configuration  
1)	  Browse to the Select SQL Deployment option page.
2)	Under SQL databases, leave Resource type set to Single database, and select Create.
 
Figure 6: Azure SQL Deployment
3)	Select Review + create at the bottom of the page:  

Figure 7 : SQL DB
(b )  Cosmos DB Configuration   
a.	Create an Azure Cosmos DB account.
b.	From the Azure portal menu or the Home page, select Create a resource.
c.	Search for Azure Cosmos DB. Select Create > Azure Cosmos DB.
d.	On the Create an Azure Cosmos DB account page, select the Create option within the Azure Cosmos DB for NoSQL section
e.	Select Review + create.
 
Figure 8 : AZURE COSMOS dB  DEPOLYMENT

 
Figure 9 Azure cosmos DEPOLYMENT



•	Go to the Manage Section And In this section just link your Services for upcoming pipeline setup : basically here we are managing our db. connections  for our pipeline setup 

 
Figure 10  : Configuring the Dataset :
 
C)  Configuring Source and Sink :
•	We have  initiated the setup process by configuring the "Source to Sink" connection. This connection is the bridge that enables data to flow seamlessly from SQL databases to Cosmos DB.
 
Figure 11 : Adding new Linked Service
•	Source Type Configuration: 
In this part we have  configure the connection setup, we carefully configured the source type here we have configure the our SQL server !
•	Sink Type Configuration : 
In this Part We have configure the  sink connection  for cosmos db. here we carefully  configured the our sink connector  we have configure the our Cosmos Server !









STEP :  5

Data Pipeline Design
Data Pipeline Design: Guideline Your Pipeline Design 
 
Figure 12 : Data Pipeline OVEREVIEW


In the Data Pipeline Design part first we have go the Author section  In the author section first create Nw folder where I can create all our published  custom pipeline  and in this section we have create a new pipeline


A)	Crafting a New Pipeline 
Select on the Author tab Author tab and then the Pipeline created by the template. Then check the source data by selecting Open.


 
Figure 13 : Creating The Pipeline in Our Resources



 


B)	Source Definition
In the "Source" section, we defined the source of our data. This could be SQL Server tables, queries, or stored procedures, depending on our data extraction requirements. But in our case, we are gone use to SQL Server.]
 

C)	Destination Setup
The "Sink" section allowed us to specify the destination for our data. In this case we have use Cosmos Db ( Mongodb) 

D)	Data Mapping
The "Mapping" section was pivotal in our pipeline design. Here, we mapped the desired columns or results from the source to the destination. This step ensured that data was transformed correctly during the transfer.
 
E)	Settings and User Properties
Finally settings  the user properties in their respective sections enabled us to customize the behavior of our pipeline according to our specific needs.

F)	Customization Opportunities
Azure Data Factory also provided opportunities for advanced customization,  for Data Integration 

G)	Validation and Deployment
Before deploying our pipeline into our Azure environment,  In this section we are validate our pipeline for making free error and  build our pipeline this section 

H)	Seamless Deployment
After validated, our pipeline was ready for deployment. In this section we have deploy  our pipeline into our Azure environment, 
 


             STEP : 6 

                                        Data Movement Initiatives
 In this section our focus to Managing its Performance and activity and ensuring the reliability 
Pipeline Monitoring : 
I)	In this section we are Monitoring our deployment of pipeline 
Select the Monitor tab Monitor tab.
 
J)	You can see an overview of your pipeline runs in the Monitor tab, such as run start time, status, etc


 




















            STEP : 7
                                                         Triggering Automation

In the Trigger Section We have added the Trigger in our pipeline, we harnessed the power of triggers to drive dynamic data updates and ensure our information remained current. This section outlines how we added triggers and deployed them within our pipeline, allowing us reflect changes..
1)	Add The New Trigger 
 
We introduced triggers to our data pipeline to automate data updates at predefined intervals or in response to specific events. With the help of theses trigger data movements and 

 transformations.
2)	Deploy The Trigger Action In Azure Cloud 
 
3)	Published the  Trigger in our Running Pipeline  

4)	Output of our Trigger in the Pipeline 
 
In the pictorial data, the green zone indicates that our trigger action is functioning correctly. It is actively fetching data from your source database every 2 minutes. 
 


 






 





