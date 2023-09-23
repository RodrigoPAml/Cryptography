# Cryptography

Repository to provide studies and algorithms of the main cryptography methods via C#

AES - For symmetric encryption

RSA - For asymmetric encryption

## AES

AES, or Advanced Encryption Standard, is a widely used symmetric encryption algorithm that is used to secure data. It was established as the encryption standard by the U.S. National Institute of Standards and Technology (NIST) in 2001 and has since become a global encryption standard.

### Algorithm Overview

AES operates on blocks of data and supports key lengths of 128, 192, or 256 bits. The algorithm consists of several rounds of processing, with the number of rounds depending on the key length. Here's a high-level overview of how AES works:

1. **Key Expansion**: The first step is to expand the encryption key. Depending on the key length, this process generates a series of round keys, which are derived from the original encryption key. Each round key is used in the subsequent encryption rounds.

2. **Initial Round (AddRoundKey)**: In the first round, the plaintext data is XORed with the initial round key. This step introduces randomness into the data.

3. **Main Rounds (SubBytes, ShiftRows, MixColumns, AddRoundKey)**: After the initial round, a series of main rounds are performed. Each main round consists of four transformations applied to the data:

   - **SubBytes**: This step involves substituting each byte of data with another byte from a fixed substitution table called the S-box. This substitution provides confusion by making the relationship between the plaintext and ciphertext more complex.

   - **ShiftRows**: In this step, the rows of the data block are shifted to the left. The number of shifts is determined by the row number. This diffusion step ensures that changes in one part of the data block affect the entire block.

   - **MixColumns**: In this transformation, each column of the data block is mixed using a mathematical operation that involves matrix multiplication. This further increases the complexity of the encryption process.

   - **AddRoundKey**: In each main round, the data is XORed with the corresponding round key. This adds another layer of key-based randomness to the data.

4. **Final Round (SubBytes, ShiftRows, AddRoundKey)**: The final round is similar to the main rounds but lacks the MixColumns step.

5. **Output**: After all the rounds are completed, the encrypted data (ciphertext) is generated. It is the result of the final AddRoundKey operation.

### Decryption

Decryption using AES is essentially the reverse process of encryption. The ciphertext is processed in reverse order, with each round key used in the decryption process being the inverse of the round key used during encryption. This reversibility ensures that the original plaintext can be recovered from the ciphertext using the correct decryption key.

### Security

AES is considered secure and is widely used for encrypting sensitive data in various applications, including secure communication, file encryption, and data storage. Its strength lies in its ability to provide both confusion (through substitution and permutation) and diffusion (through shifting and mixing), making it resistant to various cryptographic attacks. The security of AES largely depends on the length and secrecy of the encryption key.

### The Importance of Using Initialization Vectors (IV)

In symmetric encryption algorithms like AES, an Initialization Vector (IV) plays a crucial role in enhancing the security of encrypted data. An IV is a random value that is generated for each encryption operation and is used in conjunction with the encryption key. Here's why using an IV is important:

1. **Uniqueness**: The IV ensures that even if the same plaintext is encrypted multiple times with the same key, the resulting ciphertext will be different. This uniqueness prevents attackers from identifying patterns in the ciphertext, which can be exploited to break the encryption.

2. **Security Against Known-Plaintext Attacks**: Without an IV, an attacker might notice that the same plaintext always produces the same ciphertext when encrypted with the same key. This knowledge can be used in known-plaintext attacks, where an attacker has access to both the plaintext and its corresponding ciphertext. By using an IV, the ciphertext for identical plaintexts will differ, thwarting such attacks.

3. **Security Against Chosen-Plaintext Attacks**: In chosen-plaintext attacks, an attacker can select arbitrary plaintexts and observe the corresponding ciphertexts. If the encryption doesn't use an IV, the attacker may still discern patterns in the ciphertext, making it easier to deduce information about the key or the plaintext. An IV helps to obfuscate these patterns.

4. **Enhancing Encryption Strength**: An IV adds an extra layer of randomness to the encryption process. It introduces an element of "unpredictability" to the encryption, making it more resistant to various cryptographic attacks.

5. **Secure Streaming Encryption**: IVs are particularly important in streaming encryption scenarios, where data is encrypted and transmitted in small chunks or continuously. Without a unique IV for each chunk, an attacker could potentially deduce information about the plaintext by analyzing patterns in the ciphertext.

6. **Compatibility**: Some encryption modes, such as Cipher Block Chaining (CBC), require the use of an IV to provide secure encryption. In CBC mode, each ciphertext block depends on the previous block and the IV, making it mathematically necessary for secure decryption.

In summary, using an Initialization Vector (IV) is an essential practice in symmetric encryption algorithms like AES. It enhances security by ensuring uniqueness, preventing pattern recognition, and thwarting various types of attacks. When implementing AES encryption, it is crucial to generate a random and unique IV for each encryption operation to maximize security.

### Example

```C#
// If the text/file is to large, you might want to split it and encrypt using diferrents iv in each part for more security
var key = Utils.GenerateRandomKey(32);  // key byte length (32*8) = 256 
var iv = Utils.GenerateRandomKey(16);

var result = AES.Encrypt("text_to_hide", key, iv);

Console.WriteLine(AES.Decrypt(result, key, iv));
```

## RSA Encryption

RSA, which stands for Rivest–Shamir–Adleman, is a widely used asymmetric encryption algorithm that enables secure communication over the internet and the protection of sensitive information. Unlike symmetric encryption, which uses a single secret key for both encryption and decryption, RSA uses a pair of keys: a public key and a private key.

### How RSA Works

1. **Key Generation**: In RSA, the key generation process begins with the generation of a public-private key pair.

   - **Public Key**: The public key consists of two components: a modulus (n) and an exponent (e). The public key is used for encryption and is made available to anyone who wants to send encrypted messages to the owner of the private key.

   - **Private Key**: The private key also consists of two components: a modulus (n) and a different exponent (d). The private key is kept secret and is used for decryption. It is known only to the owner.

2. **Encryption**: To encrypt a message using RSA, the sender obtains the recipient's public key and performs the following steps:

   - Convert the plaintext message into a numerical value.
   - Apply the recipient's public key (n and e) to this numerical value using modular exponentiation to produce the ciphertext.

3. **Decryption**: The recipient, who possesses the corresponding private key (n and d), can decrypt the ciphertext as follows:

   - Apply the private key using modular exponentiation to recover the original numerical value.
   - Convert the numerical value back into the plaintext message.

### Strengths of RSA

1. **Asymmetry**: RSA encryption relies on the mathematical difficulty of factoring the product of two large prime numbers (n). While encryption is efficient, factoring a large semiprime (the product of two primes) is considered computationally infeasible, making it extremely secure.

2. **Public and Private Key Pair**: The use of separate keys for encryption and decryption provides a high level of security. The public key can be freely distributed, while the private key remains confidential.

3. **Digital Signatures**: RSA can also be used for digital signatures, allowing individuals to sign documents electronically, ensuring their authenticity and integrity.

### Considerations and Best Practices

1. **Key Length**: The security of RSA relies on the length of the keys. Longer key lengths provide stronger security but require more computational resources. Common key lengths include 2048 bits and 4096 bits.

2. **Key Management**: Safeguarding the private key is crucial. Losing the private key can result in data loss or compromised security.

3. **Performance**: RSA encryption and decryption can be computationally intensive, especially with longer key lengths. Many systems use hybrid encryption, where RSA is used to encrypt a symmetric encryption key for bulk data encryption.


### Example

```C#
(string publicKey, string privateKey) = Utils.GenerateRSAKeys(2048); // in bits

var result = RSA.Encrypt("text_to_hide", publicKey);

Console.WriteLine(RSA.Decrypt(result, privateKey));
```

## How RSA and AES are Used in HTTPS

RSA and AES are cryptographic algorithms used in HTTPS (Hypertext Transfer Protocol Secure) to provide security for data transmission over the internet. HTTPS is the secure version of HTTP and is widely used to protect sensitive information such as login credentials, financial transactions, and personal data.

### RSA (Rivest-Shamir-Adleman):

- **Key Exchange**: RSA is primarily used for key exchange in HTTPS. When a client (e.g., a web browser) connects to a secure website, the server's RSA public key is used to establish a secure communication channel. Here's a simplified version of how it works:
  - The server's RSA public key is sent to the client during the initial handshake.
  - The client generates a random symmetric key (usually an AES key) and encrypts it with the server's RSA public key. This encrypted key is then sent back to the server.
  - Only the server, with its corresponding RSA private key, can decrypt the symmetric key. Once decrypted, both the client and server have the same symmetric key for encrypting and decrypting data during the session.

### AES (Advanced Encryption Standard):

- **Data Encryption**: AES is used for encrypting the actual data being exchanged between the client and server after the initial key exchange. It is a symmetric-key encryption algorithm, meaning the same key is used for both encryption and decryption.
  - Once the client and server have established a shared symmetric key (often referred to as the "session key"), they use AES to encrypt and decrypt data exchanged during the session.
  - AES is highly efficient for bulk data encryption, making it well-suited for securing the actual data being transmitted in HTTPS.

### Server Certificate:

- **Authentication and Public Key**: In addition to key exchange and data encryption, HTTPS also involves server authentication. The server presents a digital certificate signed by a trusted Certificate Authority (CA). This certificate contains the server's public key (usually an RSA public key) and information about the server's identity.
  - The client verifies the server's certificate by checking if it is signed by a trusted CA and if it matches the server's hostname.
  - Usually a digital certificate can have a chain of others certificates that assure trust (root certificates, intermediate certificates and server certificate)
  - This process ensures that the client is communicating with the legitimate server and not an impostor (man-in-the-middle).

Here's a simplified step-by-step process of how RSA, AES, and the server's certificate are used in HTTPS:

1. **Handshake**: 
   - The client initiates a connection to the server.
   - The server sends its RSA public key and its digital certificate to the client.
   - The client verifies the server's certificate.
   - The client generates a random symmetric key (AES key), encrypts it with the server's RSA public key (from the certificate), and sends it back to the server.
   - Only the server, with its corresponding RSA private key, can decrypt the symmetric key. Once decrypted, both the client and server have the same symmetric key for encrypting and decrypting data during the HTTPS session.

2. **Secure Session**:
   - Both the client and server now have the same symmetric key (session key).
   - They use AES with the session key to encrypt and decrypt all data exchanged during the HTTPS session. This includes HTTP request and response messages, cookies, and any other data sent between the two parties.

The combination of RSA for key exchange, AES for data encryption, and the server certificate for authentication ensures the confidentiality, integrity, and authenticity of data transmitted over HTTPS. This triple-layered approach allows for efficient and secure communication between clients and servers on the internet.

