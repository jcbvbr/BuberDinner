﻿using BuberDinner.Domain.Common.ValueObjects;
using BuberDinner.Domain.Menu;
using ErrorOr;
using MediatR;

namespace BuberDinner.Application.Menus.Commands.CreateMenu
{
    public record CreateMenuCommand(
        string HostId,
        string Name,
        string Description,
        AverageRating? AverageRating,
        List<MenuSectionCommand> Sections) : IRequest<ErrorOr<Menu>>;

    public record MenuSectionCommand(string Name, string Description, List<MenuItemCommand> Items);

    public record MenuItemCommand(string Name, string Description);
}
