using LiquidTechnologies.XmlObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LiquidXmlObjects.Course
{
    /// <summary>
    /// The following code is intended to demonstrate the basics of using the 
    /// Liquid XML Objects code you have just generated.
    /// 
    /// The creation of the sample code is an option within the XML Data Binder
    /// Wizard and can be turned off.
    /// </summary>
    internal class SampleUsage
    {
        /// <summary>
        /// Demonstrates how to read XML data into a generated object.
        /// In this case the first element in your schema was selected.
        /// </summary>
        /// <remarks>
        /// LxSerializer.Deserialize has a number of other overloads
        /// allowing data to be read from a file/Stream/TextReader/XmlReader 
        /// </remarks>
        /// <exception cref="LxSerializationException">LxSerializer.Deserialize will throw if the XML data contains errors</exception>
        public void SimpleXmlReader()
        {
            #region Read <ns:course xmlns:ns='http://jw.nju.edu.cn/schema'>
            {
                string sampleXml = @"<ns:course xmlns:ns='http://jw.nju.edu.cn/schema'>
                                        <!-- Place your own XML code here -->
                                   </ns:course>";

                // A LxSerializer is required to de-serialize the XML data into a 
                // generated Liquid XML Objects class.
                LxSerializer<LiquidXmlObjects.Course.Jw.CourseElm> serializer = new LxSerializer<LiquidXmlObjects.Course.Jw.CourseElm>();

                using (TextReader textReader = new StringReader(sampleXml))
                {
                    // The settings in LxReaderSettings govern the behaviour of the De-serialization
                    // in this example we will provide our own error handler callback function.
                    LxReaderSettings readerSettings = new LxReaderSettings();
                    readerSettings.ErrorHandler = XmlReader_ErrorHandler;

                    // reads XML data from a TextReader, which it uses to 
                    // create and populate a LiquidXmlObjects.Course.Jw.CourseElm
                    LiquidXmlObjects.Course.Jw.CourseElm courseElm = serializer.Deserialize(textReader, readerSettings);

                    // TODO use the courseElm object ...
                }
            }
            #endregion

            #region Read <ns:department xmlns:ns='http://www.nju.edu.cn/schema'>
            {
                string sampleXml = @"<ns:department xmlns:ns='http://www.nju.edu.cn/schema'>
                                        <!-- Place your own XML code here -->
                                   </ns:department>";

                // A LxSerializer is required to de-serialize the XML data into a 
                // generated Liquid XML Objects class.
                LxSerializer<LiquidXmlObjects.Course.Nju.DepartmentElm> serializer = new LxSerializer<LiquidXmlObjects.Course.Nju.DepartmentElm>();

                using (TextReader textReader = new StringReader(sampleXml))
                {
                    // The settings in LxReaderSettings govern the behaviour of the De-serialization
                    // in this example we will provide our own error handler callback function.
                    LxReaderSettings readerSettings = new LxReaderSettings();
                    readerSettings.ErrorHandler = XmlReader_ErrorHandler;

                    // reads XML data from a TextReader, which it uses to 
                    // create and populate a LiquidXmlObjects.Course.Nju.DepartmentElm
                    LiquidXmlObjects.Course.Nju.DepartmentElm departmentElm = serializer.Deserialize(textReader, readerSettings);

                    // TODO use the departmentElm object ...
                }
            }
            #endregion

            #region Read <ns:person xmlns:ns='http://www.nju.edu.cn/schema'>
            {
                string sampleXml = @"<ns:person xmlns:ns='http://www.nju.edu.cn/schema'>
                                        <!-- Place your own XML code here -->
                                   </ns:person>";

                // A LxSerializer is required to de-serialize the XML data into a 
                // generated Liquid XML Objects class.
                LxSerializer<LiquidXmlObjects.Course.Nju.PersonElm> serializer = new LxSerializer<LiquidXmlObjects.Course.Nju.PersonElm>();

                using (TextReader textReader = new StringReader(sampleXml))
                {
                    // The settings in LxReaderSettings govern the behaviour of the De-serialization
                    // in this example we will provide our own error handler callback function.
                    LxReaderSettings readerSettings = new LxReaderSettings();
                    readerSettings.ErrorHandler = XmlReader_ErrorHandler;

                    // reads XML data from a TextReader, which it uses to 
                    // create and populate a LiquidXmlObjects.Course.Nju.PersonElm
                    LiquidXmlObjects.Course.Nju.PersonElm personElm = serializer.Deserialize(textReader, readerSettings);

                    // TODO use the personElm object ...
                }
            }
            #endregion

            #region Read <ns:student xmlns:ns='http://jw.nju.edu.cn/schema'>
            {
                string sampleXml = @"<ns:student xmlns:ns='http://jw.nju.edu.cn/schema'>
                                        <!-- Place your own XML code here -->
                                   </ns:student>";

                // A LxSerializer is required to de-serialize the XML data into a 
                // generated Liquid XML Objects class.
                LxSerializer<LiquidXmlObjects.Course.Jw.StudentElm> serializer = new LxSerializer<LiquidXmlObjects.Course.Jw.StudentElm>();

                using (TextReader textReader = new StringReader(sampleXml))
                {
                    // The settings in LxReaderSettings govern the behaviour of the De-serialization
                    // in this example we will provide our own error handler callback function.
                    LxReaderSettings readerSettings = new LxReaderSettings();
                    readerSettings.ErrorHandler = XmlReader_ErrorHandler;

                    // reads XML data from a TextReader, which it uses to 
                    // create and populate a LiquidXmlObjects.Course.Jw.StudentElm
                    LiquidXmlObjects.Course.Jw.StudentElm studentElm = serializer.Deserialize(textReader, readerSettings);

                    // TODO use the studentElm object ...
                }
            }
            #endregion

            #region Read <ns:studentList xmlns:ns='http://www.nju.edu.cn/schema'>
            {
                string sampleXml = @"<ns:studentList xmlns:ns='http://www.nju.edu.cn/schema'>
                                        <!-- Place your own XML code here -->
                                   </ns:studentList>";

                // A LxSerializer is required to de-serialize the XML data into a 
                // generated Liquid XML Objects class.
                LxSerializer<LiquidXmlObjects.Course.Nju.StudentListElm> serializer = new LxSerializer<LiquidXmlObjects.Course.Nju.StudentListElm>();

                using (TextReader textReader = new StringReader(sampleXml))
                {
                    // The settings in LxReaderSettings govern the behaviour of the De-serialization
                    // in this example we will provide our own error handler callback function.
                    LxReaderSettings readerSettings = new LxReaderSettings();
                    readerSettings.ErrorHandler = XmlReader_ErrorHandler;

                    // reads XML data from a TextReader, which it uses to 
                    // create and populate a LiquidXmlObjects.Course.Nju.StudentListElm
                    LiquidXmlObjects.Course.Nju.StudentListElm studentListElm = serializer.Deserialize(textReader, readerSettings);

                    // TODO use the studentListElm object ...
                }
            }
            #endregion

            #region Read <ns:课程成绩列表 xmlns:ns='http://jw.nju.edu.cn/schema'>
            {
                string sampleXml = @"<ns:课程成绩列表 xmlns:ns='http://jw.nju.edu.cn/schema'>
                                        <!-- Place your own XML code here -->
                                   </ns:课程成绩列表>";

                // A LxSerializer is required to de-serialize the XML data into a 
                // generated Liquid XML Objects class.
                LxSerializer<LiquidXmlObjects.Course.Jw.课程成绩列表Elm> serializer = new LxSerializer<LiquidXmlObjects.Course.Jw.课程成绩列表Elm>();

                using (TextReader textReader = new StringReader(sampleXml))
                {
                    // The settings in LxReaderSettings govern the behaviour of the De-serialization
                    // in this example we will provide our own error handler callback function.
                    LxReaderSettings readerSettings = new LxReaderSettings();
                    readerSettings.ErrorHandler = XmlReader_ErrorHandler;

                    // reads XML data from a TextReader, which it uses to 
                    // create and populate a LiquidXmlObjects.Course.Jw.课程成绩列表Elm
                    LiquidXmlObjects.Course.Jw.课程成绩列表Elm 课程成绩列表Elm = serializer.Deserialize(textReader, readerSettings);

                    // TODO use the 课程成绩列表Elm object ...
                }
            }
            #endregion


        }

        /// <summary>
        /// This method is called when an error or warning is reported during
        /// the de-serialization process. 
        /// The method must throw an Exception in order to stop the de-serialization 
        /// process. If it returns, the error/warning is ignored.
        /// </summary>
        /// <param name="msg">The error message describing the issue</param>
        /// <param name="severity">The severity of the error</param>
        /// <param name="errorCode">The error code providing detail about the issue</param>
        /// <param name="location">The location of the issue in the source XML document</param>
        /// <param name="targetObject">The object the data is being de-serialized into (a Liquid XML Objects generated class)</param>
        private void XmlReader_ErrorHandler(string msg, LxErrorSeverity severity, LxErrorCode errorCode, TextLocation location, object targetObject)
        {
            Console.WriteLine($"{severity}:{errorCode}:{location} {msg}");

            // throwing an exception will stop de-serialization
            if (severity == LxErrorSeverity.Error)
                throw new LxSerializationException(msg, severity, errorCode, location, targetObject);

            // returning will cause the warning/error to be ignored and serialization will continue
        }






        /// <summary>
        /// Demonstrates how to serialize a generated Liquid XML object to XML.
        /// In this case the first element in your schema was selected.
        /// </summary>
        /// <remarks>
        /// LxSerializer.Serialize has a number of other overloads
        /// allowing data to be written to a file/Stream/TextWriter/XmlWriter
        /// </remarks>
        /// <exception cref="LxSerializationException">LxSerializer.Serialize will throw if the object being serialized contains errors</exception>
        public void SimpleXmlWriter()
        {
            #region Write <ns:course xmlns:ns='http://jw.nju.edu.cn/schema'>
            {
                // A LxSerializer is required to serialize the XML data into a 
                // generated Liquid XML Objects class.
                LxSerializer<LiquidXmlObjects.Course.Jw.CourseElm> serializer = new LxSerializer<LiquidXmlObjects.Course.Jw.CourseElm>();

                LiquidXmlObjects.Course.Jw.CourseElm courseElm = new LiquidXmlObjects.Course.Jw.CourseElm();
                // TODO populate the object
                // courseElm.xyz = value;

                using (StringWriter writer = new StringWriter())
                {
                    LxWriterSettings writerSettings = new LxWriterSettings();
                    writerSettings.ErrorHandler = XmlWriter_ErrorHandler;

                    serializer.Serialize(writer, courseElm, writerSettings);

                    Console.Write(writer.ToString());
                }
            }
            #endregion

            #region Write <ns:department xmlns:ns='http://www.nju.edu.cn/schema'>
            {
                // A LxSerializer is required to serialize the XML data into a 
                // generated Liquid XML Objects class.
                LxSerializer<LiquidXmlObjects.Course.Nju.DepartmentElm> serializer = new LxSerializer<LiquidXmlObjects.Course.Nju.DepartmentElm>();

                LiquidXmlObjects.Course.Nju.DepartmentElm departmentElm = new LiquidXmlObjects.Course.Nju.DepartmentElm();
                // TODO populate the object
                // departmentElm.xyz = value;

                using (StringWriter writer = new StringWriter())
                {
                    LxWriterSettings writerSettings = new LxWriterSettings();
                    writerSettings.ErrorHandler = XmlWriter_ErrorHandler;

                    serializer.Serialize(writer, departmentElm, writerSettings);

                    Console.Write(writer.ToString());
                }
            }
            #endregion

            #region Write <ns:person xmlns:ns='http://www.nju.edu.cn/schema'>
            {
                // A LxSerializer is required to serialize the XML data into a 
                // generated Liquid XML Objects class.
                LxSerializer<LiquidXmlObjects.Course.Nju.PersonElm> serializer = new LxSerializer<LiquidXmlObjects.Course.Nju.PersonElm>();

                LiquidXmlObjects.Course.Nju.PersonElm personElm = new LiquidXmlObjects.Course.Nju.PersonElm();
                // TODO populate the object
                // personElm.xyz = value;

                using (StringWriter writer = new StringWriter())
                {
                    LxWriterSettings writerSettings = new LxWriterSettings();
                    writerSettings.ErrorHandler = XmlWriter_ErrorHandler;

                    serializer.Serialize(writer, personElm, writerSettings);

                    Console.Write(writer.ToString());
                }
            }
            #endregion

            #region Write <ns:student xmlns:ns='http://jw.nju.edu.cn/schema'>
            {
                // A LxSerializer is required to serialize the XML data into a 
                // generated Liquid XML Objects class.
                LxSerializer<LiquidXmlObjects.Course.Jw.StudentElm> serializer = new LxSerializer<LiquidXmlObjects.Course.Jw.StudentElm>();

                LiquidXmlObjects.Course.Jw.StudentElm studentElm = new LiquidXmlObjects.Course.Jw.StudentElm();
                // TODO populate the object
                // studentElm.xyz = value;

                using (StringWriter writer = new StringWriter())
                {
                    LxWriterSettings writerSettings = new LxWriterSettings();
                    writerSettings.ErrorHandler = XmlWriter_ErrorHandler;

                    serializer.Serialize(writer, studentElm, writerSettings);

                    Console.Write(writer.ToString());
                }
            }
            #endregion

            #region Write <ns:studentList xmlns:ns='http://www.nju.edu.cn/schema'>
            {
                // A LxSerializer is required to serialize the XML data into a 
                // generated Liquid XML Objects class.
                LxSerializer<LiquidXmlObjects.Course.Nju.StudentListElm> serializer = new LxSerializer<LiquidXmlObjects.Course.Nju.StudentListElm>();

                LiquidXmlObjects.Course.Nju.StudentListElm studentListElm = new LiquidXmlObjects.Course.Nju.StudentListElm();
                // TODO populate the object
                // studentListElm.xyz = value;

                using (StringWriter writer = new StringWriter())
                {
                    LxWriterSettings writerSettings = new LxWriterSettings();
                    writerSettings.ErrorHandler = XmlWriter_ErrorHandler;

                    serializer.Serialize(writer, studentListElm, writerSettings);

                    Console.Write(writer.ToString());
                }
            }
            #endregion

            #region Write <ns:课程成绩列表 xmlns:ns='http://jw.nju.edu.cn/schema'>
            {
                // A LxSerializer is required to serialize the XML data into a 
                // generated Liquid XML Objects class.
                LxSerializer<LiquidXmlObjects.Course.Jw.课程成绩列表Elm> serializer = new LxSerializer<LiquidXmlObjects.Course.Jw.课程成绩列表Elm>();

                LiquidXmlObjects.Course.Jw.课程成绩列表Elm 课程成绩列表Elm = new LiquidXmlObjects.Course.Jw.课程成绩列表Elm();
                // TODO populate the object
                // 课程成绩列表Elm.xyz = value;

                using (StringWriter writer = new StringWriter())
                {
                    LxWriterSettings writerSettings = new LxWriterSettings();
                    writerSettings.ErrorHandler = XmlWriter_ErrorHandler;

                    serializer.Serialize(writer, 课程成绩列表Elm, writerSettings);

                    Console.Write(writer.ToString());
                }
            }
            #endregion


        }

        /// <summary>
        /// This method is called when an error or warning is reported during
        /// the serialization process. 
        /// The method must throw an Exception in order to stop the serialization 
        /// process. If it returns, the error/warning is ignored.
        /// </summary>
        /// <param name="msg">The error message describing the issue</param>
        /// <param name="severity">The severity of the error</param>
        /// <param name="errorCode">The error code providing detail about the issue</param>
        /// <param name="targetObject">The object the data is being de-serialized into (a Liquid XML Objects generated class)</param>
        private void XmlWriter_ErrorHandler(string msg, LxErrorSeverity severity, LxErrorCode errorCode, object targetObject)
        {
            Console.WriteLine($"{severity}:{errorCode} {msg}");

            // throwing an exception will stop Serialization
            if (severity == LxErrorSeverity.Error)
                throw new LxSerializationException(msg, severity, errorCode, null, targetObject);

            // returning will cause the warning/error to be ignored and serialization will continue
        }






        /// <summary>
        /// Typically when you read an XML document you know what the root element 
        /// should be, however in some instances the root element may not be known at 
        /// design time. This sample demonstrates how to deal with this.
        /// </summary>
        /// <exception cref="LxException">LxSerializer.Deserialize will throw if the generated 
        /// Liquid XML Objects library does not contain an object capable of having the XML data 
        /// de-serialized into it.</exception>
        public void ReadingXmlOfUnknownType()
        {
            string sampleXml = @"<ns:课程成绩列表 xmlns:ns='http://jw.nju.edu.cn/schema'>
                                    <!-- Place your own XML code here -->
                               </ns:课程成绩列表>";

            // Note we use the un-templated version
            LxSerializer serializer = new LxSerializer();

            using (TextReader textReader = new StringReader(sampleXml))
            {
                // reads XML data from a TextReader, which it uses to 
                // create and populate a LiquidXmlObjects.Course.Jw.课程成绩列表Elm
                XmlQualifiedName rootElementName;
                Object rootObject = serializer.Deserialize(textReader, out rootElementName);

                if (rootObject is LiquidXmlObjects.Course.Jw.课程成绩列表Elm)
                {
                    LiquidXmlObjects.Course.Jw.课程成绩列表Elm 课程成绩列表Elm = (LiquidXmlObjects.Course.Jw.课程成绩列表Elm)rootObject;
                    //if (课程成绩列表Elm is SomeClassType myClass)
                    //{
                    //    myClass.MyProperty = 5;
                    //}
                    //else if (课程成绩列表Elm is SomeOtherClassType myOtherClass)
                    //{
                    //    myOtherClass.MyOtherProperty = "New value";
                    //}
                    //else
                    //{
                    //    throw new NotSupportedException();
                    //}
                }
                else
                {
                    throw new NotImplementedException($"No handler provided for the root element {rootElementName}");
                }
            }
        }





        /// <summary>
        /// Uses the original XML Schemas to build a validator that can be used to
        /// validate the XML data directly or create a validating reader.
        /// </summary>
        /// <remarks>
        /// Note:
        /// SchemaSetValidator.Validate and SchemaSetValidator.CreateValidatingReader 
        /// has a number of other overloads allowing data to be read from a file/Stream/TextReader/XmlReader 
        /// </remarks>
        public void ValidateUsingOriginalXmlSchema()
        {
            SchemaSetValidator validator = new SchemaSetValidator();

            // validating an XML document directly
            validator.Validate("PathOfXmlDocument.xml", ValidateUsingOriginalXmlSchema_ValidationEventHandler);

            // creating a validating XML reader 
            XmlReader validatingXmlReader = validator.CreateValidatingReader("PathOfXmlDocument.xml", ValidateUsingOriginalXmlSchema_ValidationEventHandler);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(validatingXmlReader);
        }

        /// <summary>
        /// Called back when the SchemaSetValidator encounters validation errors and warnings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateUsingOriginalXmlSchema_ValidationEventHandler(object sender, System.Xml.Schema.ValidationEventArgs e)
        {
            Console.WriteLine($"{e.Severity}:{e.Message}");
        }
    }
}
