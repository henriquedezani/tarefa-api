CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;

CREATE TABLE "Tarefas" (
    "Id" text NOT NULL,
    "Texto" text NULL,
    "Finalizada" boolean NOT NULL,
    CONSTRAINT "PK_Tarefas" PRIMARY KEY ("Id")
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20211018190315_Add Tarefa Model', '5.0.11');

COMMIT;

START TRANSACTION;

ALTER TABLE "Tarefas" ALTER COLUMN "Texto" TYPE character varying(200);
ALTER TABLE "Tarefas" ALTER COLUMN "Texto" SET NOT NULL;
ALTER TABLE "Tarefas" ALTER COLUMN "Texto" SET DEFAULT '';

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20211018190905_Define campo Texto como obrigatório', '5.0.11');

COMMIT;

