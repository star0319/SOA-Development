///////////////////////////////////////////////////////////////////////////
//           Liquid XML Objects GENERATED CODE - DO NOT MODIFY           //
//            https://www.liquid-technologies.com/xml-objects            //
//=======================================================================//
// Dependencies                                                          //
//     Nuget : LiquidTechnologies.XmlObjects.Runtime                     //
//           : MUST BE VERSION 19.0.14                                   //
//=======================================================================//
// Online Help                                                           //
//     https://www.liquid-technologies.com/xml-objects-quick-start-guide //
//=======================================================================//
// Licensing Information                                                 //
//     https://www.liquid-technologies.com/eula                          //
///////////////////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Numerics;
using LiquidTechnologies.XmlObjects;
using LiquidTechnologies.XmlObjects.Attribution;

// ------------------------------------------------------
// |                      Settings                      |
// ------------------------------------------------------
// GenerateCommonBaseClass                  = False
// GenerateUnprocessedNodeHandlers          = True
// RaiseChangeEvents                        = False
// CollectionNaming                         = Pluralize
// Language                                 = CS
// OutputNamespace                          = LiquidXmlObjects.Course
// WriteDefaultValuesForOptionalAttributes  = True
// WriteDefaultValuesForOptionalElements    = False
// GenerationModel                          = Simple
//                                            *WARNING* this simplified model that is very easy to work with
//                                            but may cause the XML to be produced without regard for element
//                                            cardinality or order. Where very high compliance with the XML Schema
//                                            standard is required use GenerationModelType.Conformant
// XSD Schema Files
//    C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\Course.xsd
//    C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\Department.xsd
//    C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\PersonInfo.xsd
//    C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\Student.xsd
//    C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\ScoreList.xsd
//    C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\StudentList.xsd


namespace LiquidXmlObjects.Course
{
    #region Global Settings
    /// <summary>Contains library level properties, and ensures the version of the runtime used matches the version used to generate it.</summary>
    [LxRuntimeRequirements("19.0.14.11049", "Trial for Non-Commercial Use Expiry [2022-04-29]", "H5C8JK5GPLV4ECU4", LiquidTechnologies.XmlObjects.LicenseTermsType.Trial)]
    public partial class LxRuntimeRequirementsWritten
    {
    }

    #endregion

    #region Global Base Class
    /// <summary>All generated Lx classes derive from this base class.</summary>
    /// <remarks>Notes to implementers. The class is declared partial, so additional members and properties can be added that will be available in all Lx generated classes.</remarks>
    public partial class LxBase
    {
        #region Unprocessed Node Handlers
        /// <summary>Any child elements that do not belong in this element are added to the UnprocessedElements collection.</summary>
        [LxElementUnprocessed()]
        public List<XElement> UnprocessedElements { get; } = new List<XElement>();

        /// <summary>Any attributes that do not belong in this element are added to the UnprocessedAttributes collection.</summary>
        [LxAttributeUnprocessed()]
        public List<XAttribute> UnprocessedAttributes { get; } = new List<XAttribute>();

        #endregion

    }

    #endregion

}

namespace LiquidXmlObjects.Course.Jw
{
    #region Enumerations
    /// <summary>An enumeration representing XSD simple type 成绩性质类型@http://jw.nju.edu.cn/schema</summary>
    /// <XsdPath>schema:ScoreList.xsd/simpleType:成绩性质类型</XsdPath>
    /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\ScoreList.xsd</XsdFile>
    /// <XsdLocation>12:5-20:18</XsdLocation>
    public enum 成绩性质类型Enum
    {
        /// <summary>Represents the value '平时成绩' in the XML</summary>
        [LxEnumValue("平时成绩")]
        平时成绩,
        /// <summary>Represents the value '作业成绩' in the XML</summary>
        [LxEnumValue("作业成绩")]
        作业成绩,
        /// <summary>Represents the value '期中成绩' in the XML</summary>
        [LxEnumValue("期中成绩")]
        期中成绩,
        /// <summary>Represents the value '期末成绩' in the XML</summary>
        [LxEnumValue("期末成绩")]
        期末成绩,
        /// <summary>Represents the value '总评成绩' in the XML</summary>
        [LxEnumValue("总评成绩")]
        总评成绩,
    }
    #endregion

    #region Complex Types
    /// <summary>A class representing the root XSD complexType courseInfo@http://jw.nju.edu.cn/schema</summary>
    /// <XsdPath>schema:Course.xsd/complexType:courseInfo</XsdPath>
    /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\Course.xsd</XsdFile>
    /// <XsdLocation>13:3-35:17</XsdLocation>
    [LxSimpleComplexTypeDefinition("courseInfo", "http://jw.nju.edu.cn/schema")]
    public partial class CourseInfoCt : LiquidXmlObjects.Course.LxBase
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue("name", "http://jw.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1)]
        public System.String Name { get; set; } = "";

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        [LxElementValue("departmentId", "http://jw.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1)]
        public System.Numerics.BigInteger DepartmentId { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue("semister", "http://jw.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1)]
        public System.String Semister { get; set; } = "";

        /// <summary>A collection of <see cref="System.Numerics.BigInteger" /></summary>
        [LxElementValue("teacherId", "http://jw.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<System.Numerics.BigInteger> TeacherIds { get; } = new List<System.Numerics.BigInteger>();

        /// <summary>A collection of <see cref="LiquidXmlObjects.Course.Jw.CourseInfoCt.ScheduleElm" /></summary>
        [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<LiquidXmlObjects.Course.Jw.CourseInfoCt.ScheduleElm> Schedules { get; } = new List<LiquidXmlObjects.Course.Jw.CourseInfoCt.ScheduleElm>();

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue("id", "http://jw.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, Length = "6")]
        public System.String Id { get; set; } = "";

        /// <summary>Represent the inline xs:element schedule@http://jw.nju.edu.cn/schema.</summary>
        /// <XsdPath>schema:Course.xsd/complexType:courseInfo/sequence/element:schedule</XsdPath>
        /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\Course.xsd</XsdFile>
        /// <XsdLocation>24:7-31:17</XsdLocation>
        [LxSimpleElementDefinition("schedule", "http://jw.nju.edu.cn/schema", ElementScopeType.InlineElement)]
        public partial class ScheduleElm : LiquidXmlObjects.Course.LxBase
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("time", "http://jw.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1)]
            public System.String Time { get; set; } = "";

            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            [LxElementValue("classroom", "http://jw.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1)]
            public System.String Classroom { get; set; } = "";

        }

    }

    /// <summary>A class representing the root XSD complexType studentInfo@http://jw.nju.edu.cn/schema</summary>
    /// <XsdPath>schema:Student.xsd/complexType:studentInfo</XsdPath>
    /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\Student.xsd</XsdFile>
    /// <XsdLocation>16:3-26:17</XsdLocation>
    [LxSimpleComplexTypeDefinition("studentInfo", "http://jw.nju.edu.cn/schema")]
    public partial class StudentInfoCt : LiquidXmlObjects.Course.Nju.PersonInfoCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue("studentId", "http://jw.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, Length = "9")]
        public System.String StudentId { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue("major", "http://jw.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1)]
        public System.String Major { get; set; } = "";

        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Course.Jw.课程成绩列表类型Ct" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Course.Jw.课程成绩列表类型Ct" />
        /// </summary>
        [LxElementCt("grades", "http://jw.nju.edu.cn/schema", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Course.Jw.课程成绩列表类型Ct Grades { get; set; } = new LiquidXmlObjects.Course.Jw.课程成绩列表类型Ct();

    }

    /// <summary>A class representing the root XSD complexType 成绩类型@http://jw.nju.edu.cn/schema</summary>
    /// <XsdPath>schema:ScoreList.xsd/complexType:成绩类型</XsdPath>
    /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\ScoreList.xsd</XsdFile>
    /// <XsdLocation>38:5-43:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("成绩类型", "http://jw.nju.edu.cn/schema")]
    public partial class 成绩类型Ct : LiquidXmlObjects.Course.LxBase
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue("学号", "http://jw.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, Length = "9")]
        public System.String 学号 { get; set; } = "";

        /// <summary>A <see cref="System.Int32" />, Required</summary>
        [LxElementValue("得分", "http://jw.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdInt, MinOccurs = 1, MaxOccurs = 1, MaxInclusive = "100", MinInclusive = "0")]
        public System.Int32 得分 { get; set; }

    }

    /// <summary>A class representing the root XSD complexType 课程成绩类型@http://jw.nju.edu.cn/schema</summary>
    /// <XsdPath>schema:ScoreList.xsd/complexType:课程成绩类型</XsdPath>
    /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\ScoreList.xsd</XsdFile>
    /// <XsdLocation>28:5-36:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("课程成绩类型", "http://jw.nju.edu.cn/schema")]
    public partial class 课程成绩类型Ct : LiquidXmlObjects.Course.LxBase
    {
        /// <summary>The value for the optional attribute 课程编号</summary>
        /// <XsdPath>schema:ScoreList.xsd/complexType:课程成绩类型/attribute:课程编号</XsdPath>
        /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\ScoreList.xsd</XsdFile>
        /// <XsdLocation>34:9-34:51</XsdLocation>
        [LxAttribute("课程编号", "", LxValueType.Value, XsdType.XsdString, Length = "6")]
        public System.String 课程编号 { get; set; }

        /// <summary>The value for the optional attribute 成绩性质</summary>
        /// <XsdPath>schema:ScoreList.xsd/complexType:课程成绩类型/attribute:成绩性质</XsdPath>
        /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\ScoreList.xsd</XsdFile>
        /// <XsdLocation>35:9-35:51</XsdLocation>
        [LxAttribute("成绩性质", "", LxValueType.Enum, XsdType.Enum, WhiteSpace = WhiteSpaceType.Preserve)]
        public LiquidXmlObjects.Course.Jw.成绩性质类型Enum? 成绩性质 { get; set; }

        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Course.Jw.成绩类型Ct" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Course.Jw.成绩类型Ct" />
        /// </summary>
        [LxElementCt("成绩", "http://jw.nju.edu.cn/schema", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<LiquidXmlObjects.Course.Jw.成绩类型Ct> 成绩s { get; } = new List<LiquidXmlObjects.Course.Jw.成绩类型Ct>();

    }

    /// <summary>A class representing the root XSD complexType 课程成绩列表类型@http://jw.nju.edu.cn/schema</summary>
    /// <XsdPath>schema:ScoreList.xsd/complexType:课程成绩列表类型</XsdPath>
    /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\ScoreList.xsd</XsdFile>
    /// <XsdLocation>22:5-26:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("课程成绩列表类型", "http://jw.nju.edu.cn/schema")]
    public partial class 课程成绩列表类型Ct : LiquidXmlObjects.Course.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Course.Jw.课程成绩类型Ct" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Course.Jw.课程成绩类型Ct" />
        /// </summary>
        [LxElementCt("课程成绩", "http://jw.nju.edu.cn/schema", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<LiquidXmlObjects.Course.Jw.课程成绩类型Ct> 课程成绩s { get; } = new List<LiquidXmlObjects.Course.Jw.课程成绩类型Ct>();

    }

    #endregion

    #region Elements
    /// <summary>A class representing the root XSD element course@http://jw.nju.edu.cn/schema</summary>
    /// <XsdPath>schema:Course.xsd/element:course</XsdPath>
    /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\Course.xsd</XsdFile>
    /// <XsdLocation>37:3-37:48</XsdLocation>
    [LxSimpleElementDefinition("course", "http://jw.nju.edu.cn/schema", ElementScopeType.GlobalElement)]
    public partial class CourseElm : LiquidXmlObjects.Course.Jw.CourseInfoCt
    {
    }

    /// <summary>A class representing the root XSD element student@http://jw.nju.edu.cn/schema</summary>
    /// <XsdPath>schema:Student.xsd/element:student</XsdPath>
    /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\Student.xsd</XsdFile>
    /// <XsdLocation>28:3-28:50</XsdLocation>
    [LxSimpleElementDefinition("student", "http://jw.nju.edu.cn/schema", ElementScopeType.GlobalElement)]
    public partial class StudentElm : LiquidXmlObjects.Course.Jw.StudentInfoCt
    {
    }

    /// <summary>A class representing the root XSD element 课程成绩列表@http://jw.nju.edu.cn/schema</summary>
    /// <XsdPath>schema:ScoreList.xsd/element:课程成绩列表</XsdPath>
    /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\ScoreList.xsd</XsdFile>
    /// <XsdLocation>52:5-52:49</XsdLocation>
    [LxSimpleElementDefinition("课程成绩列表", "http://jw.nju.edu.cn/schema", ElementScopeType.GlobalElement)]
    public partial class 课程成绩列表Elm : LiquidXmlObjects.Course.Jw.课程成绩列表类型Ct
    {
    }

    #endregion

}

namespace LiquidXmlObjects.Course.Tns
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType anyType@http://www.w3.org/2001/XMLSchema</summary>
    /// <XsdPath>schema:.../www.w3.org/2001/XMLSchema/complexType:anyType</XsdPath>
    /// <XsdFile>http://www.w3.org/2001/XMLSchema</XsdFile>
    /// <XsdLocation>Empty</XsdLocation>
    [LxSimpleComplexTypeDefinition("anyType", "http://www.w3.org/2001/XMLSchema")]
    public partial class AnyTypeCt : XElement
    {
        /// <summary>Constructor : create a <see cref="AnyTypeCt" /> element &lt;anyType xmlns='http://www.w3.org/2001/XMLSchema'&gt;</summary>
        public AnyTypeCt()  : base(XName.Get("anyType", "http://www.w3.org/2001/XMLSchema")) { }

    }

    #endregion

}

namespace LiquidXmlObjects.Course.Nju
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType departmentInfo@http://www.nju.edu.cn/schema</summary>
    /// <XsdPath>schema:Department.xsd/complexType:departmentInfo</XsdPath>
    /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\Department.xsd</XsdFile>
    /// <XsdLocation>6:3-13:17</XsdLocation>
    [LxSimpleComplexTypeDefinition("departmentInfo", "http://www.nju.edu.cn/schema")]
    public partial class DepartmentInfoCt : LiquidXmlObjects.Course.LxBase
    {
        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        [LxElementValue("id", "http://www.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1)]
        public System.Numerics.BigInteger Id { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue("name", "http://www.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1)]
        public System.String Name { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue("address", "http://www.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1)]
        public System.String Address { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue("contact", "http://www.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1)]
        public System.String Contact { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType personInfo@http://www.nju.edu.cn/schema</summary>
    /// <XsdPath>schema:PersonInfo.xsd/complexType:personInfo</XsdPath>
    /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\PersonInfo.xsd</XsdFile>
    /// <XsdLocation>6:3-22:17</XsdLocation>
    [LxSimpleComplexTypeDefinition("personInfo", "http://www.nju.edu.cn/schema")]
    public partial class PersonInfoCt : LiquidXmlObjects.Course.LxBase
    {
        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        [LxElementValue("id", "http://www.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1)]
        public System.Numerics.BigInteger Id { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue("name", "http://www.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1)]
        public System.String Name { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue("contact", "http://www.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1)]
        public System.String Contact { get; set; } = "";

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        [LxElementValue("age", "http://www.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1)]
        public System.Numerics.BigInteger Age { get; set; }

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        [LxElementValue("departmentId", "http://www.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1)]
        public System.Numerics.BigInteger DepartmentId { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue("gender", "http://www.nju.edu.cn/schema", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, Pattern = "male|female|others|unknown")]
        public System.String Gender { get; set; } = "";

    }

    #endregion

    #region Elements
    /// <summary>A class representing the root XSD element department@http://www.nju.edu.cn/schema</summary>
    /// <XsdPath>schema:Department.xsd/element:department</XsdPath>
    /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\Department.xsd</XsdFile>
    /// <XsdLocation>15:3-15:57</XsdLocation>
    [LxSimpleElementDefinition("department", "http://www.nju.edu.cn/schema", ElementScopeType.GlobalElement)]
    public partial class DepartmentElm : LiquidXmlObjects.Course.Nju.DepartmentInfoCt
    {
    }

    /// <summary>A class representing the root XSD element person@http://www.nju.edu.cn/schema</summary>
    /// <XsdPath>schema:PersonInfo.xsd/element:person</XsdPath>
    /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\PersonInfo.xsd</XsdFile>
    /// <XsdLocation>24:3-24:49</XsdLocation>
    [LxSimpleElementDefinition("person", "http://www.nju.edu.cn/schema", ElementScopeType.GlobalElement)]
    public partial class PersonElm : LiquidXmlObjects.Course.Nju.PersonInfoCt
    {
    }

    /// <summary>A class representing the root XSD element studentList@http://www.nju.edu.cn/schema</summary>
    /// <XsdPath>schema:StudentList.xsd/element:studentList</XsdPath>
    /// <XsdFile>C:\Users\84158\Desktop\OneDrive - 南京大学\pc\myfile\learning_materia\大三下\soa\assignment\2\第10组作业2\StudentList.xsd</XsdFile>
    /// <XsdLocation>11:3-17:13</XsdLocation>
    [LxSimpleElementDefinition("studentList", "http://www.nju.edu.cn/schema", ElementScopeType.GlobalElement)]
    public partial class StudentListElm : LiquidXmlObjects.Course.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Course.Jw.StudentInfoCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Course.Jw.StudentInfoCt" />
        /// </summary>
        [LxElementCt("student", "http://www.nju.edu.cn/schema", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Course.Jw.StudentInfoCt Student { get; set; } = new LiquidXmlObjects.Course.Jw.StudentInfoCt();

    }

    #endregion

}

namespace LiquidXmlObjects.Course
{
    /// <summary>
    /// Provides a validator based on the original XSD schema files. 
    /// </summary>
    public partial class SchemaSetValidator : LiquidTechnologies.XmlObjects.XsdValidator
    {
        /// <summary>
        /// Initializes the validator, loads and compiles the XSD schemas.
        /// </summary>
        /// <remarks>
        /// This is an expensive operation so consider caching this object.
        /// </remarks>
        public SchemaSetValidator()
            : base(typeof(SchemaSetValidator).Assembly, "LiquidXmlObjects.Course.SchemaSetResources.SchemaData")
        {
        }
    }
}
