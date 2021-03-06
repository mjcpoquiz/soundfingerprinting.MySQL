﻿namespace SoundFingerprinting.MySQL
{
    using SoundFingerprinting.DAO;

    public class MySqlModelService : ModelService
    {
        public MySqlModelService()
            : base(new TrackDao(), new HashBinDao(), new SubFingerprintDao(), new FingerprintDao(), new SpectralImageDao())
        {
            // no op
        }

        protected MySqlModelService(
            ITrackDao trackDao,
            IHashBinDao hashBinDao,
            ISubFingerprintDao subFingerprintDao,
            IFingerprintDao fingerprintDao,
            ISpectralImageDao spectralImageDao)
            : base(trackDao, hashBinDao, subFingerprintDao, fingerprintDao, spectralImageDao)
        {
            // no op
        }
    }
}
