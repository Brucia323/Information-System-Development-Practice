CREATE DATABASE supermarket --�������ݿ�
GO
USE supermarket --����ѯ�༭�������л������ݿ�
GO
CREATE TABLE users --������Ա��
(
    tel CHAR(11) PRIMARY KEY NOT NULL,
    --�绰
    username NVARCHAR(10) NOT NULL,
    --����
    sex NCHAR(5) NULL CHECK(sex='��' or sex='Ů'),
    --�Ա�
    points INT NOT NULL,
    --����
    passwords VARCHAR(16) NOT NULL,
    --����
    registrationtime DATETIME NOT NULL
    --ע��ʱ��
)
GO
CREATE TABLE cart --�������ﳵ��
(
    tel CHAR(11) NOT NULL,
    --�绰
    productnumber CHAR(10) NOT NULL,
    --��Ʒ���
    quantity INT NOT NULL,
    --����
    selectedstatus CHAR(1) NOT NULL,
    --ѡ��״̬
    jointime DATETIME NOT NULL,
    --����ʱ��
    PRIMARY KEY (tel,productnumber)
)
GO
CREATE TABLE orderproducts --����������Ʒ��
(
    ordernumber CHAR(10) NOT NULL,
    --������
    itemnumber INT NOT NULL,
    --��Ʒ���
    purchasequantity INT NOT NULL
        --��������
        PRIMARY KEY (ordernumber,itemnumber)
)
GO
CREATE TABLE returnorders --�����˻�������
(
    ordernumber CHAR(10) PRIMARY KEY NOT NULL,
    --������
    applicationtime DATETIME NOT NULL,
    --����ʱ��
    returntime DATETIME NULL,
    --�˻�ʱ��
    refundtime DATETIME NULL,
    --�˿�ʱ��
    stf NVARCHAR(10) NOT NULL
    --����Ա��
)
GO

/* USE master
GO
DROP DATABASE supermarket
GO */