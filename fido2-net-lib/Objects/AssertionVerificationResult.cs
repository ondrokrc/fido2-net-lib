namespace Fido2NetLib.Objects
{
    /// <summary>
    /// Result of the MakeAssertion verification
    /// </summary>
    public class AssertionVerificationSuccess
    {
        public byte[] CredentialId { get; internal set; }
        public uint Counter { get; internal set; }

        public string Status { get; set; } = "ok";
         public string ErrorMessage { get; set; } = "";
    }
}
