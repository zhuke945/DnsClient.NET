namespace DnsClient.Records
{
	public class RecordSSHFP : RDataRecord
    {
        public RecordSSHFP(ResourceRecord resource, RecordReader recordReader)
            : base(resource, recordReader)
        {
        }

        public override string ToString()
        {
            return string.Format("not-used");
        }
    }
}