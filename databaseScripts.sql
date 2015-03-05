CREATE TABLE UNIT(
ID INT PRIMARY KEY,
NAME VARCHAR,
MINIMAL_VALUE INT);

CREATE TABLE PAYMENT_TYPE(
ID INT PRIMARY KEY,
PAYMENT_TYPE_NAME VARCHAR);

CREATE TABLE PRODUCT(
ID INT PRIMARY KEY,
NAME VARCHAR,
UNIT INT FOREIGN KEY,
PRODUCT_TYPE INT FOREIGN KEY,
EXPIRY_DATE DATE,
PRICE FLOAT
);

CREATE TABLE PRODUCT_TYPE(
ID INT PRIMARY KEY,
NAME VARCHAR);

CREATE TABLE CLIENT(
ID INT PRIMARY KEY,
NAME VARCHAR,
SURNAME VARCHAR,
NIP INT,
COMPANY_NAME VARCHAR,
CLIENT_TYPE VARCHAR,
ADDRESS INT FOREIGN KEY,
TELEPHONE VARCHAR,
EMAIL VARCHAR);

CREATE TABLE ADDRESS(
ID INT PRIMARY KEY,
STREET VARCHAR,
HOME_NUMBER INT,
FLAT_NUMBER INT);

CREATE TABLE PRODUCT_LIST(
ID INT PRIMARY KEY,
PRODUCT_ID INT FOREIGN KEY,
ORDER_NUMBER VARCHAR);

CREATE TABLE EMPLOYEE(
ID INT PRIMARY KEY,
NAME VARCHAR,
SURNAME VARCHAR,
LOGIN VARCHAR,
PASSWORD VARCHAR,
TELEPHONE VARCHAR,
EMAIL VARCHAR,
);

CREATE TABLE _ORDER(
ID INT PRIMARY KEY,
CLIENT INT FOREIGN KEY,
ORDER_NUMBER VARCHAR,
PAYMENT_TYPE INT FOREIGN KEY,
EMPLOYEE_ID INT FOREIGN KEY);