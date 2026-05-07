using System.ComponentModel.DataAnnotations; namespace FormSubmission.AdminPortal.Models;
public class CreateSubmissionRequest { [Required,MinLength(2),MaxLength(100)] public string FullName {get;set;}=string.Empty; [Required,EmailAddress,MaxLength(150)] public string Email {get;set;}=string.Empty; [Required,MinLength(5),MaxLength(1000)] public string Message {get;set;}=string.Empty; }
public record SubmissionDto(Guid Id,string FullName,string Email,string Message,string Status,DateTime CreatedAtUtc,DateTime? UpdatedAtUtc);
public record CreateSubmissionResponse(Guid Id); public record UpdateStatusRequest(string Status); public record LoginRequest(string Username,string Password); public record LoginResponse(string Token,string Username,string Role);
