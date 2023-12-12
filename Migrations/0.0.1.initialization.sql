/* v0.0.1 Initialization Of Schema */
/* Creating User Schema */

CREATE USER c##learn_csharp IDENTIFIED BY password;
-- DROP USER c##learn_csharp

/* Granting Required Privileges  */
GRANT CONNECT, RESOURCE TO c##learn_csharp;

-- CONNECT c##learn_csharp/password
-- SHOW USER; 

-- SELECT tname FROM tab;