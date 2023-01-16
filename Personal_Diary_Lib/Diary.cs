using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Diary_Lib
{
    public class Diary
    {

        #region Public Constants
        public const int DATE_LENGTH = 4;
        public const int TIME_MAX_LENGTH = 50;
        public const int NAME_MAX_LENGTH = 50;
        public const int PLACE_MAX_LENGTH = 50;
        public const int DURATION_MAX_LENGTH = 10;
        public const int NOTE_MAX_LENGTH = 40;

        public const int DIARY_DATA_BLOCK_SIZE = DATE_LENGTH +
                                                NAME_MAX_LENGTH +
                                                TIME_MAX_LENGTH +
                                                DURATION_MAX_LENGTH +
                                                NOTE_MAX_LENGTH +
                                                PLACE_MAX_LENGTH;
        #endregion

        #region Private Fields
        private string _date;
        private string _time;
        private string _name;
        private string _place;
        private string _duration;
        private string _note;

        #endregion

        #region Public Properties
        public string Date { get { return _date; } set { _date = value; } }
        public string Time { get { return _time; } set { _time = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Place { get { return _place; } set { _place = value; } }
        public string Duration { get { return _duration; } set { _duration = value; } }
        public string Note { get { return _note; } set { _note = value; } }

        #endregion

        #region Utility Methods
        public static byte[] DiaryToByteArrayBlock(Diary diary)
        {
            int index = 0;

            byte[] dataBuffer = new byte[DIARY_DATA_BLOCK_SIZE];

            #region copy diary date
            byte[] idBytes = ConversionUtility.StringToByteArray(diary.Date);
            Array.Copy(idBytes, 0, dataBuffer, index, idBytes.Length);
            index += Diary.DATE_LENGTH;
            #endregion

            #region copy diary time
            byte[] diaryBytes = ConversionUtility.StringToByteArray(diary.Date);
            Array.Copy(diaryBytes, 0, dataBuffer, index, diaryBytes.Length);
            index += Diary.TIME_MAX_LENGTH;
            #endregion

            #region copy diary name
            byte[] nameBytes = ConversionUtility.StringToByteArray(diary.Name);
            Array.Copy(nameBytes, 0, dataBuffer, index, nameBytes.Length);
            index += Diary.NAME_MAX_LENGTH;
            #endregion

            #region copy diary place
            byte[] placeBytes = ConversionUtility.StringToByteArray(diary.Place);
            Array.Copy(placeBytes, 0, dataBuffer, index, placeBytes.Length);
            index += Diary.PLACE_MAX_LENGTH;
            #endregion

            #region copy diary duration
            byte[] durationBytes = ConversionUtility.StringToByteArray(diary.Duration);
            Array.Copy(durationBytes, 0, dataBuffer, index, durationBytes.Length);
            index += Diary.DURATION_MAX_LENGTH;
            #endregion

            #region copy diary note
            byte[] noteBytes = ConversionUtility.StringToByteArray(diary.Note);
            Array.Copy(noteBytes, 0, dataBuffer, index, noteBytes.Length);
            index += Diary.NOTE_MAX_LENGTH;
            #endregion


            #endregion

            if (index != dataBuffer.Length)
            {
                throw new ArgumentException("Index and DataBuffer Size Not Matched");
            }

            return dataBuffer;
        }

        public static Diary ByteArrayBlockToDiary(byte[] byteArray)
        {

            Diary diary = new Diary();

            if (byteArray.Length != DIARY_DATA_BLOCK_SIZE)
            {
                throw new ArgumentException("Byte Array Size Not Match with Constant Data Block Size");
            }

            int index = 0;

            //byte[] dataBuffer = new byte[BOOK_DATA_BLOCK_SIZE];

            #region copy diary date
            byte[] dateBytes = new byte[Diary.DATE_LENGTH];
            Array.Copy(byteArray, index, dateBytes, 0, dateBytes.Length);
            diary.Date = ConversionUtility.ByteArrayToString(dateBytes);

            index += Diary.DATE_LENGTH;
            #endregion

            #region copy diary time
            byte[] nameBytes = new byte[Diary.TIME_MAX_LENGTH];
            Array.Copy(byteArray, index, nameBytes, 0, nameBytes.Length);
            diary.Time = ConversionUtility.ByteArrayToString(nameBytes);

            index += Diary.TIME_MAX_LENGTH;
            #endregion

            #region copy diary name
            byte[] addressBytes = new byte[Diary.NAME_MAX_LENGTH];
            Array.Copy(byteArray, index, addressBytes, 0, addressBytes.Length);
            diary.Name = ConversionUtility.ByteArrayToString(addressBytes);

            index += Diary.NAME_MAX_LENGTH;
            #endregion

            #region copy diary place
            byte[] parentsnameBytes = new byte[Diary.PLACE_MAX_LENGTH];
            Array.Copy(byteArray, index, parentsnameBytes, 0, parentsnameBytes.Length);
            diary.Place = ConversionUtility.ByteArrayToString(parentsnameBytes);

            index += Diary.PLACE_MAX_LENGTH;
            #endregion

            #region copy diary duration
            byte[] classBytes = new byte[Diary.DURATION_MAX_LENGTH];
            Array.Copy(byteArray, index, classBytes, 0, classBytes.Length);
            diary.Duration = ConversionUtility.ByteArrayToString(classBytes);

            index += Diary.DURATION_MAX_LENGTH;
            #endregion

            #region copy diary note
            byte[] phonenumberBytes = new byte[Diary.NOTE_MAX_LENGTH];
            Array.Copy(byteArray, index, phonenumberBytes, 0, phonenumberBytes.Length);
            diary.Note = ConversionUtility.ByteArrayToString(phonenumberBytes);

            index += Diary.NOTE_MAX_LENGTH;
            #endregion



            if (index != byteArray.Length)
            {
                throw new ArgumentException("Index and DataBuffer Size Not Matched");
            }

            else
            {
                return diary;
            }

        }

    }
}
