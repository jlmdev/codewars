function getDrinkByProfession(param){
  const lowercaseParam = param.toLowerCase()
  switch (lowercaseParam) {
      case 'jabroni':
        return 'Patron Tequila'
        break
      case 'school counselor':
        return 'Anything with Alcohol'
        break
      case 'programmer':
        return 'Hipster Craft Beer'
        break
      case 'bike gang member':
        return 'Moonshine'
        break
      case 'politician':
        return 'Your tax dollars'
        break
      case 'rapper':
        return 'Cristal'
        break
      default:
        return 'Beer'
  }
}
