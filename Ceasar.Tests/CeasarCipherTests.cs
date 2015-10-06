using System;
using NUnit.Framework;

namespace Ceasar.Tests
{
    public class CeasarCipherTests
    {
        //[Test]
        //public void Encrypt_WhenEmptyStringIsPassed_ReturnEmptyString()
        //{
        //    var cipher = new CeasarCipher(offset: 0);

        //    var encrypted = cipher.Encrypt("");

        //    Assert.IsEmpty(encrypted);
        //}

        //[Test]
        //public void Dencrypt_WhenEmptyStringIsPassed_ReturnEmptyString()
        //{
        //    var cipher = new CeasarCipher(offset: 0);

        //    var encrypted = cipher.Decrypt("");

        //    Assert.IsEmpty(encrypted);
        //}

        //[Test]
        //public void Encrypt_WhenPassedNull_ThrowsArgumentNullException()
        //{
        //    var cipher = new CeasarCipher(offset: 0);

        //    Assert.Throws<ArgumentNullException>(() =>
        //    {
        //        cipher.Encrypt(null);
        //    });
        //}

        //[Test]
        //public void Encrypt_WhenPassedWrongSymbol_ThrowsArgumentOutOfRangeException()
        //{
        //    var cipher = new CeasarCipher(offset: 0);
        //    var nonSymbol = (char)127;
        //    var nonSymbolString = new string(new[] { nonSymbol });

        //    Assert.Throws<ArgumentOutOfRangeException>(() =>
        //    {
        //        cipher.Encrypt(nonSymbolString);
        //    });
        //}

        //[Test]
        //public void Dencrypt_WhenPassedWrongSymbol_ThrowsArgumentOutOfRangeException()
        //{
        //    var cipher = new CeasarCipher(offset: 0);
        //    var nonSymbol = (char)127;
        //    var nonSymbolString = new string(new[] { nonSymbol });

        //    Assert.Throws<ArgumentOutOfRangeException>(() =>
        //    {
        //        cipher.Decrypt(nonSymbolString);
        //    });
        //}

        //[Test]
        //public void Dencrypt_WhenPassedNull_ThrowsArgumentNullException()
        //{
        //    var cipher = new CeasarCipher(offset: 0);

        //    Assert.Throws<ArgumentNullException>(() =>
        //    {
        //        cipher.Decrypt(null);
        //    });
        //}

        //[Test]
        //public void Encrypt_WithZeroOffset_ReturnTheSameWord()
        //{
        //    var cipher = new CeasarCipher(offset: 0);
        //    var word = "random";

        //    var encrypted = cipher.Encrypt(word);

        //    Assert.AreEqual(word, encrypted);
        //}

        //[Test]
        //public void Decrypt_WithZeroOffset_ReturnTheSameWord()
        //{
        //    var cipher = new CeasarCipher(offset: 0);
        //    var word = "random";

        //    var encrypted = cipher.Decrypt(word);

        //    Assert.AreEqual(word, encrypted);
        //}

        //[Test]
        //public void Encrypt_WithOneOffset_ShiftsSymbolsOnOnePositionRight()
        //{
        //    var cipher = new CeasarCipher(offset: 1);
        //    var word = "a";

        //    var encrypted = cipher.Encrypt(word);

        //    Assert.AreEqual("b", encrypted);
        //}

        //[Test]
        //public void Decrypt_WithOneOffset_ShiftsSymbolsOnOnePosition()
        //{
        //    var cipher = new CeasarCipher(offset: 1);
        //    var word = "b";

        //    var encrypted = cipher.Decrypt(word);

        //    Assert.AreEqual("a", encrypted);
        //}

        //[Test]
        //public void Encrypt_WithOverflow_ShouldStartFromBegingingOfAlphabet()
        //{
        //    var cipher = new CeasarCipher(offset: 1);
        //    var word = "~";

        //    var encrypted = cipher.Encrypt(word);

        //    Assert.AreEqual("!", encrypted);
        //}

        //[Test]
        //public void Decrypt_WithOverflow_ShouldStartFromBegingingOfAlphabet()
        //{
        //    var cipher = new CeasarCipher(offset: 1);
        //    var word = "!";

        //    var encrypted = cipher.Decrypt(word);

        //    Assert.AreEqual("~", encrypted);
        //}

        //[Test]
        //public void EncryptDecrypt_WithRandomSting_ProducesTheSameResult()
        //{
        //    var cipher = new CeasarCipher(offset: 5);
        //    var word = "Testing with some random string";

        //    var encrypted = cipher.Encrypt(word);

        //    Assert.AreEqual(word, cipher.Decrypt(encrypted));
        //}
    }
}
