# CSN-DTO (Data Transfer Objects)

An standardised format for transfer of data within the automotive industry globally. This is developed and in use by carsales.com Limited and its local and international entities.

There are four main classes.
1. **Customer** (aka Seller / Dealer / User): Describes the entity associated with the business. This could be a private seller, a dealer, an OEM or any other business / legal entity.
2. **Vehicle**: Specific details of the automotive inventory item - this is a specific item, e.g. identified by VIN or HIN and must be related to a *Customer*, and have a *Specification*.
3. **Specification**: Describes the specifics of various automotive variants, including: Make, Model, Year and other details.
4. **Lead**: Details of an individual enquiry.  


## DATA TRANSFER OPTIONS

The content transferred should be in an industry standard format e.g. JSON, XML or CSV.

> Special case for CSV: 
>
> The CSV file should **always** include a header row, where the column name is the property name, including parent properties names (separated by a period: ".") where applicable to ensure uniqueness e.g. a lead can have two *Name* properties, therefore the columns should be called: *Prospect.Name*,*Seller.Name*
>
> The processing of CSV files should honour the column names provided, such that optional fields may be added or removed, and column order / position is not fixed and can be changed, without affecting processing. Carriage returns, line feeds and quotation marks should be escaped e.g. \r\n and \", and text should be enclosed in quotation marks (mandatory if the text for a field contains a comma).

### The mechanism for transferring content includes:

#### 1. HTTP POST

Using the standard web based technology as a webhook. A webhook in this instance is a HTTPS endpoint that receives a body of data via HTTP POST. This POST will generally be the specific content type of the content being posted. It is the responsibility of the receiver of the data to provide a realible end point for the sender to POST the data to. As a general rule, to maintain maximum compatibility, the endpoint should be a specific endpoint for each of the data types (i.e. vehicle, lead, customer or specification) and not require or include any further variable parameters in either the path, query string or the headers. It is only the body of the request that contains the content variation.

There is no standard on the returned content in the body of the response from the web hook. The success or failure of the call should rely on the HTTP response codes. Systems should take action based on the following response codes:
 - 2xx - is considered accepted and no further action should be taken.
 - 3xx - is honoured, and any redirection should be followed.
 - 4xx - means a permanent failure, and a system should **NOT** retry.
 - 5xx - is a temporary failure and a system should resend the data after waiting an agreed period of time.

Authorisation of the HTTP POST should occur if desired based on the entity **sending** the data, and **not** the entity the data relates to. Mechanisms include specific custom (fixed) headers or query string (fixed) parameters. 

#### 2. FTP

The content is stored in a file and transmitted using File Transfer Protocol (FTP). There should be no variability in the path details except for the data type (i.e. vehicle, lead, customer or specification) required to submit the file. Authorisation should be based on the entity **sending** the data and **not** the entity the data relates to.

In the case where the file relates to a single item, e.g. a vehicle or seller, then the file name should be the unique identifier for that item with the content type, in short form, as the file extension e.g. 42539cf0-009e-408f-8b6a-630f3d2e58dc.json where 42539cf0-009e-408f-8b6a-630f3d2e58dc is the unique identifier for that item, and the content will be json describing that item.

Where the file relates to multiple items, e.g. all vehicles for a seller, or all sellers for a company, then the file should be named based on the parent entity with the content as the file extension e.g.  8b38fa0b-bace-4562-bdd7-082c7fbfd6a4.json would contain a JSON array for items where 8b38fa0b-bace-4562-bdd7-082c7fbfd6a4 is the parent.

### NOTE:
Generally speaking it will be the receiver of the data that should host the HTTP or FTP service. As data should always be pushed by the sender (reduces over-the-network polling requirements). There may be instances where this is not possible, e.g. network related requirements (firewall etc.) and therefore the sender may host the files or objects for download.
