# Strengthen user account's password security

## Use case
As a software security manager
I want to strengthen private access to my application
In order to avoid user account hacking

## General rules
- A password should be at least 8 characters long.
- A password should have at least one uppercase letter.
- A password should have at least one lowercase letter.
- A password should have at least one number.
- A password should have at least one special character ( #, $ or @ ).

### Valid examples

 - @Azerty123
 - $JohnDoe0

### Invalid examples
- Azerty123
- #123456789
- ARandomPasswordQuiteLongEnough

## Acceptance tests

### Registration should throw an error when an invalid password is submitted
> **When** an user registers with his mail "sample@mail.com" and the password "abc123" 
>
> **Then** the following error is thrown "**Unsecured password submitted.**"

### Change user account's password should throw an error when an invalid password is submitted
> **Given** an already registered user "sample@mail.com" 
>
> **When** the user "sample@mail.com" changes his password to "abc123" 
>
> **Then** the following error is thrown "**Unsecured password submitted.**"
