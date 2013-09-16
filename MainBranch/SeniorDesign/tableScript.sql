###################################################################################
# tableScript.sql   (a script file)
###################################################################################

-- Create the DB

DROP DATABASE IF EXISTS CrimeReport;
CREATE DATABASE CrimeReport;

-- Subsequent tables will be created in the report DB

USE CrimeReport;

-- Table structure for table `Reports`

DROP TABLE IF EXISTS `Reports`;
CREATE TABLE `Reports` (
  `DayWeek` char(3)   default '',
  `Month` char(3)   default '',
  `Day` int(2)  ,
  `Year` int(4)  ,
  `Name` char(40)   default '',
  `AddressNum` int(10) default NULL,
  `Street` char(25)   default 'na',
  `City` char(14) default NULL,
  `State` char(13) default NULL,
  `Zip` int(5) default NULL,
  `CrimeType` char(17)   default '',
  `Area` int(5) ,
  `TimePeriod` char(10) default NULL,
  `PropertyDescription` char(70) default NULL,
  `RecoveredValue` int(10) ,
  `LostStolenDamagedValue` int(10)  ,
  `Assignment` char(30)   default '',
  `Status` char(15)   default '',
  `FelonyMisd` char(14) default '',
  `GangRel` char(5) default '',
  `ArrestsMade` int(4)  ,
  `ComplaintNum` int(10) default 0 ,
  `Year2` int(4)  ,
  `DetecAssist1` char(30)   default '',
  `DetecAssist2` char(30)   default '',
  `DetecAssist3` char(30)   default '',
  `DetecAssist4` char(30)   default '',
  `DetecAssist5` char(30)   default '',
  `PrintDna` char(12)   default '',
  `BusinessName` char(30)   default '',
  `Remarks` char(200)   default '',
  PRIMARY KEY  (`ComplaintNum`)
);
