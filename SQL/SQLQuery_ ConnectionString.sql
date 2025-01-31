-- Server=myServerName\myInstanceName;Database=myDataBase;User Id=myUsername;Password=myPassword;

SELECT 
    @@SERVERNAME AS 'ServerName', 
    DB_NAME() AS 'DatabaseName',
    SESSIONPROPERTY('net_transport') AS 'NetTransport',
    SESSIONPROPERTY('protocol_type') AS 'ProtocolType',
    SESSIONPROPERTY('auth_scheme') AS 'AuthScheme'


SELECT 
    'Server=' + @@SERVERNAME + '; Database=' + DB_NAME() + ';' AS ConnectionString
