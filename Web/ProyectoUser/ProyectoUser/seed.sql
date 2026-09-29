SET QUOTED_IDENTIFIER ON;
SET ANSI_NULLS ON;
DECLARE @RoleId NVARCHAR(450) = NEWID();
DECLARE @UserId NVARCHAR(450) = NEWID();

-- 1. Crear rol Admin
IF NOT EXISTS (SELECT 1 FROM AspNetRoles WHERE Name = 'Admin')
BEGIN
    INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp)
    VALUES (@RoleId, 'Admin', 'ADMIN', NEWID());
    PRINT 'Rol Admin creado';
END
ELSE
BEGIN
    SELECT @RoleId = Id FROM AspNetRoles WHERE Name = 'Admin';
    PRINT 'Rol Admin ya existe';
END

-- 2. Crear usuario Admin
IF NOT EXISTS (SELECT 1 FROM AspNetUsers WHERE UserName = 'admin@proyecto.com')
BEGIN
    INSERT INTO AspNetUsers (
        Id, UserName, NormalizedUserName, Email, NormalizedEmail, 
        EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, 
        PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount
    )
    VALUES (
        @UserId, 
        'admin@proyecto.com', 
        'ADMIN@PROYECTO.COM', 
        'admin@proyecto.com', 
        'ADMIN@PROYECTO.COM',
        1,
        'AQAAAACghgEAEAAAAAECAwQFBgcICQoLDA0ODxAgAAAAHcXuAK10SjWLJPp2fjPLGDZzYBUHjuLTj/VUPgmfEuE=',
        NEWID(),
        NEWID(),
        0, 0, 1, 0
    );
    PRINT 'Usuario admin@proyecto.com creado';
END
ELSE
BEGIN
    SELECT @UserId = Id FROM AspNetUsers WHERE UserName = 'admin@proyecto.com';
    PRINT 'Usuario admin@proyecto.com ya existe';
END

-- 3. Asignar rol al usuario
IF NOT EXISTS (SELECT 1 FROM AspNetUserRoles WHERE UserId = @UserId AND RoleId = @RoleId)
BEGIN
    INSERT INTO AspNetUserRoles (UserId, RoleId)
    VALUES (@UserId, @RoleId);
    PRINT 'Rol Admin asignado al usuario';
END
ELSE
BEGIN
    PRINT 'El usuario ya tiene el rol Admin';
END
