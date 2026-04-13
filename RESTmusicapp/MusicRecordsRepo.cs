namespace RESTmusicapp
{
    public class MusicRecordsRepo
    {
        private List<MusicRecord> m_mucicrecords = new List<MusicRecord>();

        private static int nextid = 1;

        public MusicRecordsRepo() { }

        public IEnumerable<MusicRecord> GetAll()
        {
            List<MusicRecord> musicRecords = new List<MusicRecord>(m_mucicrecords);
            return musicRecords;
        }

        public MusicRecord? GetById(int id)
        {
            MusicRecord musicRecord = m_mucicrecords.FirstOrDefault(m => m.Id == id);
            if (musicRecord == null)
            {
                return null;
            }
            MusicRecord musicrecordcopy = new MusicRecord
            {
                Id = musicRecord.Id,
                Title = musicRecord.Title,
                Artist = musicRecord.Artist,
                Duration = musicRecord.Duration,
                PublicationYear = musicRecord.PublicationYear

            };
            return musicrecordcopy;

        }

        public MusicRecord Add(MusicRecord musicRecord)
        {
            musicRecord.Id = nextid++;
            m_mucicrecords.Add(musicRecord);

            MusicRecord musicrecordcopy = new MusicRecord
            {
                Id = musicRecord.Id,
                Title = musicRecord.Title,
                Artist = musicRecord.Artist,
                Duration = musicRecord.Duration,
                PublicationYear = musicRecord.PublicationYear
            };
            return musicrecordcopy;

        }

        public MusicRecord? Remove(int id) 
        {
            MusicRecord? musicRecord = m_mucicrecords.FirstOrDefault(m => m.Id == id);
            if (musicRecord == null)
            {
                return null;
            }
            m_mucicrecords.Remove(musicRecord);

            MusicRecord musicrecordcopy = new MusicRecord
            {
                Id = musicRecord.Id,
                Title = musicRecord.Title,
                Artist = musicRecord.Artist,
                Duration = musicRecord.Duration,
                PublicationYear = musicRecord.PublicationYear
            };
            return musicrecordcopy;

        }

        }
    }
