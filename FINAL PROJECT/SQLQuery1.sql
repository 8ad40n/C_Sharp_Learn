select * from UserInfo;
select * from UserInfo2;

ALTER TABLE UserInfo2
ADD UNIQUE (Email);


delete from UserInfo2 where Username='badhonn';

UPDATE UserInfo
SET UserInfo.Password ='11111'
FROM UserInfo
INNER JOIN UserInfo2
    ON UserInfo.Username = UserInfo2.Username
WHERE UserInfo2.Email = 'abc@gmail.com';


ALTER TABLE UserInfo2
DROP CONSTRAINT Email;

