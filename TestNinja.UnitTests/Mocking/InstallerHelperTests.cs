﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    class InstallerHelperTests
    {
        private Mock<IFileDownloader> _fileDownloader;
        private InstallerHelper _installerHelper;

        [SetUp]
        public void SetUp()
        {
            _fileDownloader = new Mock<IFileDownloader>();
            _installerHelper = new InstallerHelper(_fileDownloader.Object);
        }

        [Test]
        public void DownloadInstaller_DownloadFails_ReturnFalse()
        {
            _fileDownloader.Setup(fd => 
                fd.GetFile(It.IsAny<string>(), It.IsAny<string>())).
                Throws<WebException>();

            var result = _installerHelper.DownloadInstaller("customer", "installer");

            Assert.That(result,Is.EqualTo(false));

        }

        [Test]
        public void DownloadInstaller_DownloadCompletes_ReturnTrue()
        {

            var result = _installerHelper.DownloadInstaller("customer", "installer");

            Assert.That(result, Is.EqualTo(true));

        }
    }
}
