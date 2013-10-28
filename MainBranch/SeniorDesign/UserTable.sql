DROP TABLE IF EXISTS `Users`;
CREATE TABLE `Users` (
  `UserName` char(20),
  `Password` char(80),
  `Level` int(20) default 'user',
  PRIMARY KEY  (`UserName')
);
