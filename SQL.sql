CREATE DATABASE supermarket --创建数据库
GO
USE supermarket --将查询编辑器连接切换到数据库
GO
CREATE TABLE users --创建会员表
(
    tel CHAR(11) PRIMARY KEY NOT NULL,
    --电话
    username NVARCHAR(10) NOT NULL,
    --姓名
    sex NCHAR(5) NULL CHECK(sex='男' or sex='女'),
    --性别
    points INT NOT NULL,
    --积分
    passwords VARCHAR(16) NOT NULL,
    --密码
    registrationtime DATETIME NOT NULL
    --注册时间
)
GO
CREATE TABLE cart --创建购物车表
(
    tel CHAR(11) NOT NULL,
    --电话
    productnumber CHAR(10) NOT NULL,
    --商品编号
    quantity INT NOT NULL,
    --数量
    selectedstatus CHAR(1) NOT NULL,
    --选定状态
    jointime DATETIME NOT NULL,
    --加入时间
    PRIMARY KEY (tel,productnumber)
)
GO
CREATE TABLE orderproducts --创建订单商品表
(
    ordernumber CHAR(10) NOT NULL,
    --订单号
    itemnumber INT NOT NULL,
    --商品编号
    purchasequantity INT NOT NULL
        --购买数量
        PRIMARY KEY (ordernumber,itemnumber)
)
GO
CREATE TABLE returnorders --创建退货订单表
(
    ordernumber CHAR(10) PRIMARY KEY NOT NULL,
    --订单号
    applicationtime DATETIME NOT NULL,
    --申请时间
    returntime DATETIME NULL,
    --退货时间
    refundtime DATETIME NULL,
    --退款时间
    stf NVARCHAR(10) NOT NULL
    --负责员工
)
GO

/* USE master
GO
DROP DATABASE supermarket
GO */