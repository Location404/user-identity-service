local args = {...}
local migrationName = args[1]

if not migrationName then
    print("Uso: lua add-migration.lua NomeDaMigration")
    os.exit(1)
end

local command = string.format("dotnet ef migrations add %s --project ../src/UserIdentity.Infra --startup-project ../src/UserIdentity.API", migrationName)
print("Executando:", command)

os.execute(command)
